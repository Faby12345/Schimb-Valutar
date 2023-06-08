using System.Data;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection.Metadata;

namespace mainApp
{

    public partial class Form1 : Form
    {

        SQLiteClass? DataBase;
        public static UserClass? CurrentUser;
        public static List<UserClass> Users = new List<UserClass>();
        public static List<ClientClass> Clients = new List<ClientClass>();
        public List<Currency1> itemsCurrency = new List<Currency1>();
        bool isTable = false;
        public Form1()
        { 
            this.DoubleBuffered = true;
            InitializeComponent();
            
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            InitTabs(false);
            Init();
        }

        #region Initialization
        
        void Init()
        {
            Helper.MainForm = this;
            DataBase = new SQLiteClass();

            DataTable usersData = new(), clientsData = new(), EVData = new(), buyData = new();
            LoadDataBaseTables(ref usersData, clientsData, EVData, buyData);
            InitUsers(usersData);
            InitCurrencies();
            loginControl.Init(CurrentUser = new UserClass(),Users);
        }
        void InitTabs(bool state)
        {
            for (int i = 1; i < tabControl1.TabCount; i++)
                foreach (Control ctl in tabControl1.TabPages[i].Controls)
                    ctl.Enabled = state;
        }
        void InitUsers(DataTable loadedData)
        {
            for (int i = 0; i < loadedData.Rows.Count; i++)
            {
                var v =loadedData.Rows[i].ItemArray;
                Users.Add(new UserClass()
                {
                    UserName = v[0].ToString(),
                    USerPassword = v[1].ToString(),
                    IsAdmin = Convert.ToBoolean(v[2].ToString() == "0" ? true : false)
                });
            }
        }
        private void InitCurrencies()
        {
            XMLFunctions.ReadCurrencyValues();
            foreach (Currency currency in Currency.CurrencyList)
                lvCurrencies.Items.Add(currency.Symbol);
        }
        
        private void LoadDataBaseTables(ref DataTable usersData, DataTable clientsData, DataTable EVData, DataTable buyData)
        {
            usersData = DataBase.LoadData("Users").ToTable();
            clientsData = DataBase.LoadData("Clients").ToTable();
            EVData = DataBase.LoadData("EV").ToTable();
            buyData = DataBase.LoadData("Purchases").ToTable();

            dgvDBTable.DataSource = usersData;
            dgvClientsTable.DataSource = clientsData;
            dgvSellsTable.DataSource = EVData;
            dgvBuyTable.DataSource = buyData;
            
        }
        private void tabControl1_DrawItem(object? sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];
            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw  background color.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.Silver, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
#endregion

        #region Currencies
        private void btAddCurrency_Click(object sender, EventArgs e)
        {
            string cName, cSymbol, cAmplif;
            cName = tbCurrName.Text;
            cSymbol = tbCurrSymbol.Text;
            cAmplif = tbCurrAmplification.Text;
            Currency.CurrencyList.Add(new Currency(cName, cSymbol, float.Parse(cAmplif)));
            lvCurrencies.Items.Add(Currency.CurrencyList[^1].Symbol);
            currencyTabel.AllowUserToAddRows= false;
            bool duplicateCurr = false;
            for(int i = 0; i < currencyTabel.Rows.Count; ++i)
            {
                if (currencyTabel.Rows[i].Cells[0].Value.ToString() == cName || currencyTabel.Rows[i].Cells[1].Value.ToString() == cSymbol)
                {
                    duplicateCurr = true;
                    break;
                }
            }
            if(duplicateCurr == false)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(currencyTabel);
                row.Cells[0].Value = cName;
                row.Cells[1].Value = cSymbol;
                row.Cells[2].Value = 0;
                row.Cells[3].Value = 0;
                row.Cells[4].Value = 0;
                row.Cells[5].Value = 0;
                row.Cells[6].Value = 0;
                currencyTabel.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("NU SE POATE ADAUGA ACEEASI MONEDA DE 2 ORI!!", "Warning", MessageBoxButtons.OK);
            }
           

        }

        private void lvCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = lvCurrencies.SelectedIndex < 0 ? 0 : lvCurrencies.SelectedIndex;
            tbCurrName.Text = Currency.CurrencyList[ind].Name;
            tbCurrSymbol.Text = Currency.CurrencyList[ind].Symbol;
            tbCurrAmplification.Text = Currency.CurrencyList[ind].Amplification.ToString();
        }

        private void btDelCurrency_Click(object sender, EventArgs e)
        {
            int ind = lvCurrencies.SelectedIndex;
            Currency.CurrencyList.RemoveAt(ind);
            lvCurrencies.Items.RemoveAt(ind);
            lvCurrencies.SelectedIndex = ind - 1;
        }
        private void btModifyCurrency_Click(object sender, EventArgs e)
        {
            string cName, cSymbol, cAmplif;
            int ind = lvCurrencies.SelectedIndex;
            cName = tbCurrName.Text;
            cSymbol = tbCurrSymbol.Text;
            cAmplif = tbCurrAmplification.Text;
            Currency.CurrencyList[ind].Name = cName;
            Currency.CurrencyList[ind].Symbol = cSymbol;
            float.TryParse(cAmplif, out float value);
            Currency.CurrencyList[ind].Amplification = value;
        }

        private void btSaveCurrency_Click(object sender, EventArgs e)
        {
            XMLFunctions.WriteCurrencyValues();
        }
        #endregion

        #region Restrictions
        /// <summary>
        /// Prevent unauthorized access to other tabs if user is not loged in
        /// </summary>
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!CurrentUser.IsLoggedIn && tabControl1.SelectedIndex != 0)
                tabControl1.SelectedTab = tabPage1;
            else if (CurrentUser.IsLoggedIn) InitTabs(true);
        }

        private DataGridView GetCurrencyTabel()
        {
            return currencyTabel;
        }
        #endregion
         void getDataFromTabel(List<CurrencysDB> items)
        {
            for(int i = 0; i < currencyTabel.Rows.Count; i++)
            {
                CurrencysDB item = new CurrencysDB();
                for(int j = 0; j < currencyTabel.Rows[i].Cells.Count; ++j)
                {
                    if (currencyTabel.Rows[i].Cells[j] != null)
                    {
                        item.Name = currencyTabel.Rows[i].Cells[0].Value.ToString();
                        item.Symbol = currencyTabel.Rows[i].Cells[1].Value.ToString();
                        item.SellPrice = Convert.ToDouble(currencyTabel.Rows[i].Cells[2].Value);
                        item.SellCom = Convert.ToDouble(currencyTabel.Rows[i].Cells[3].Value);
                        item.BuyPrice = Convert.ToDouble(currencyTabel.Rows[i].Cells[4].Value);
                        item.BuyCom = Convert.ToDouble(currencyTabel.Rows[i].Cells[5].Value);
                        item.Fixing = Convert.ToDouble(currencyTabel.Rows[i].Cells[6].Value);
                    }
                }

                items.Add(item);
               
            }
        }
        public bool checkForDuplicateCurrencys(string item)
        {
            const string dbPath = "URI=file:currDB.db3";
            List<CurrencysDB> items = new List<CurrencysDB>();
            getDataFromTabel(items);
                if (isTable == true)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(dbPath))
                    {
                        connection.Open();
                        SQLiteCommand readcmd = new SQLiteCommand("select * from currDB", connection);
                        SQLiteDataReader reader = readcmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader["NAME"].ToString() == item)
                            {
                            return true;
                            }
                        }
                        connection.Close();
                    }

                }

                return false;
            
        }
        public void saveCurrencyTableBtn_Click(object sender, EventArgs e)
        {
            List<CurrencysDB> items = new List<CurrencysDB>();
            getDataFromTabel(items);
            //Console.WriteLine(items[0].Name);
            const string dbPath = "URI=file:currDB.db3";
            string sql;
            
            bool ok;
            for (int i = 0; i < currencyTabel.Rows.Count; i++) 
            {
                ok = false;
                sql = "INSERT INTO currDB (ID, NAME, SYMBOL, SELLPRICE, SELLCOM, BUYPRICE, BUYCOM, FIXING) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8);";
                /**/
                
                if (ok  || isTable == true)
                {
                    if (checkForDuplicateCurrencys(items[i].Name) == false)
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                        {
                            conn.Open();
                            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@val1", i+1);
                                cmd.Parameters.AddWithValue("@val2", items[i].Name);
                                cmd.Parameters.AddWithValue("@val3", items[i].Symbol);
                                cmd.Parameters.AddWithValue("@val4", items[i].SellPrice);
                                cmd.Parameters.AddWithValue("@val5", items[i].SellCom);
                                cmd.Parameters.AddWithValue("@val6", items[i].BuyPrice);
                                cmd.Parameters.AddWithValue("@val7", items[i].BuyCom);
                                cmd.Parameters.AddWithValue("@val8", items[i].Fixing);
                                cmd.ExecuteNonQuery(); 
                            }
                            conn.Close();
                        }
                    }
  
                }
            }    
        }

        private void loginControl_Load(object sender, EventArgs e)
        {
            const string dbPath = "URI=file:currDB.db3";
            if (isTable == true)
            { 
                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(currencyTabel);
                row1.Cells[0].Value = "euro"; ;
                row1.Cells[1].Value = "EUR";
                row1.Cells[2].Value = 4.5600;
                row1.Cells[3].Value = 0;
                row1.Cells[4].Value = 4.6000;
                row1.Cells[5].Value = 0;
                row1.Cells[6].Value = 4.5590;
                currencyTabel.Rows.Add(row1);
            
            }  
            if (System.IO.File.Exists(@"C:\\Users\\fabyt\\Desktop\\c# git\\mainApp\\bin\\Debug\\net6.0-windows\\currDB.db3"))
            {
                // do nothing 
                isTable = true;
            }
            else
            {
                var db = new SQLiteConnection(dbPath);
                db.Open();
                string tb1 = "create table currDB (ID integer primay key, NAME text, SYMBOL text, SELLPRICE double, SELLCOM double, BUYPRICE double, BUYCOM double, FIXING double)";
                SQLiteCommand cmd = new SQLiteCommand(tb1, db);
                cmd.ExecuteNonQuery();
                db.Close();
                isTable = true;
            }

            int i = 0;

            /* PUT IN DATAGRIDVIEW ALL THE DATA FROM THE DATABASE*/
            if(isTable == true)
            {
                using (SQLiteConnection connection = new SQLiteConnection(dbPath))
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand("select * from currDB", connection);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    { 
                        //Console.WriteLine($"{reader["NAME"]} {reader["SYMBOL"]} {reader["SELLPRICE"]} {reader["SELLCOM"]} {reader["BUYPRICE"]} {reader["BUYCOM"]} {reader["FIXING"]}");
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(currencyTabel);
                        row.Cells[0].Value = reader["NAME"];
                        row.Cells[1].Value = reader["SYMBOL"];
                        row.Cells[2].Value = reader["SELLPRICE"];
                        row.Cells[3].Value = reader["SELLCOM"];
                        row.Cells[4].Value = reader["BUYPRICE"];
                        row.Cells[5].Value = reader["BUYCOM"];
                        row.Cells[6].Value = reader["FIXING"];
                        currencyTabel.Rows.Add(row);
                    }
                    connection.Close();
                }
            }
        }
    }
}
