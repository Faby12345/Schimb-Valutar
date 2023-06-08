using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace mainApp
{
    public partial class sellPage : UserControl
    {
        //DataTable dt = new DataTable(); // tabel
        public sellPage()
        {
            InitializeComponent();
            string RONString= "100.12355";
            double RONnum = double.Parse(RONString);
            RONStock.Text = RONString;
           

        }

        public double searchForCurrencys(string symb)
        {
            double curr = 0;
            string dbPath = "URI=file:currDB.db3";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
            {
                using (SQLiteConnection connection = new SQLiteConnection(dbPath))
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand("select * from currDB", connection);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (symb == reader["SYMBOL"].ToString())
                        {
                            curr = reader.GetDouble(5);
                            break;
                        }
                    }
                    connection.Close();
                }
               
            } 
            return curr;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            string dbPath = "URI=file:currDB.db3";

            string country = personCountry.Text;
            string fristName = personFristName.Text;
            string lastName = personLastName.Text;
            bool resident;
            string series = personSeries.Text;
            string number = personNr.Text;
            if(country != "RO")
            {
                personRezident.Text = "F";
                resident = false;
            }
            else
            {
                personRezident.Text = "A";
                resident = true;
            } // codejuuoi

            ClientClass client = new ClientClass();  
            client.FristName = fristName;
            client.LastName = lastName;
            client.FullName = fristName+ " " + lastName;
            client.Resident = resident;
            client.Series = series;
            client.Number = int.Parse(number);
            client.Country = country;
            GetDataFromTabel( client.SellItems, dataGridView1);
            /*
            string sql = "INSERT INTO clientsDB (ID, DATA, NR_BULETIN, SERIE_BULETIN, NUME, TIP, TARA) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7)";
            using (SQLiteConnection conn = new SQLiteConnection(@"C:\Users\fabyt\Desktop\c# git\mainApp\bin\Debug\net6.0-windows\clientsDB.db3"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@val1", 1);
                    cmd.Parameters.AddWithValue("@val2", client.SellItems[0].TimeOfSell.ToString());
                    cmd.Parameters.AddWithValue("@val3", client.Number);
                    cmd.Parameters.AddWithValue("@val4", client.Series);
                    cmd.Parameters.AddWithValue("@val5", client.FullName);
                    cmd.Parameters.AddWithValue("@val6", "V");
                    cmd.Parameters.AddWithValue("@val7", client.Country);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }*/
            Form1.Clients.Add(client);

            
            for(int i = 0; i < client.SellItems.Count; ++i)
            {
                if (i == 0)
                {
                    Console.WriteLine(client.SellItems[i].TimeOfSell);
                    Console.WriteLine(client.FullName);
                }
            }
            float sellPriceIn = 0, sellPriceOut = 0, itemInToRon = 0, itemOutToRon = 0;
            int j;
            for (int i = 0; i < dataGridView1.Rows.Count-1; ++i)
            {
                sellPriceIn = float.Parse(searchForCurrencys(dataGridView1.Rows[i].Cells[1].Value.ToString()).ToString());
                sellPriceOut = float.Parse(searchForCurrencys(dataGridView1.Rows[i].Cells[4].Value.ToString()).ToString());
                itemInToRon = float.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) * sellPriceIn;
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "RON")
                {
                    dataGridView1.Rows[i].Cells[2].Value = searchForCurrencys(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    dataGridView1.Rows[i].Cells[3].Value = float.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) / sellPriceOut; 
                }
                else if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "RON")
                {
                    dataGridView1.Rows[i].Cells[3].Value =  itemInToRon;
                    dataGridView1.Rows[i].Cells[2].Value = searchForCurrencys(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
                else if(sellPriceIn != 0 && sellPriceOut != 0)
                {
                    dataGridView1.Rows[i].Cells[2].Value = searchForCurrencys(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    dataGridView1.Rows[i].Cells[3].Value = itemInToRon / sellPriceOut;
                }
                else
                {
                    MessageBox.Show("NU SE POATE EFECTUA TRANZACTIA!", "Warning", MessageBoxButtons.OK);
                }
                GetDataFromTabel(client.SellItems, dataGridView1);
                Console.WriteLine(client.SellItems[i].CashIn + " " + client.SellItems[i].SymbolIn);
                Console.WriteLine(client.SellItems[i].CashOut + " " + client.SellItems[i].SymbolOut);
            }

        }

   


        void GetDataFromTabel( List<SellItem> items, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                SellItem sellItem = new SellItem();
                for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                    {
                        sellItem.CashIn = double.Parse(dgv.Rows[i].Cells[0].Value.ToString());
                        sellItem.SymbolIn = dgv.Rows[i].Cells[1].Value.ToString();                
                        sellItem.TimeOfSell = DateTime.Now;
                        
                    }
                                   
                }
            items.Add(sellItem); 
            }

        }
        private void sellPage_Load(object sender, EventArgs e)
        {
            const string dbPath = "URI=file:clientsDB.db3";
            dataGridView1.DataSource = InitTable();
            dataGridView1.Rows[0].Cells[0].Value = 0;
            dataGridView1.Rows[0].Cells[2].Value = 0;
            dataGridView1.Rows[0].Cells[3].Value = 0;
            if (System.IO.File.Exists(@"C:\Users\fabyt\Desktop\c# git\mainApp\bin\Debug\net6.0-windows\clientsDB.db3"))
            {
                // do nothing 
            }
            else
            {
                var db = new SQLiteConnection(dbPath);
                db.Open();
                string tb1 = "create table clientsDB (ID integer primay key, DATA text, NR_BULETIN text, SR_BULETIN text, NAME text, TIP text, TARA text)";
                SQLiteCommand cmd = new SQLiteCommand(tb1, db);
                cmd.ExecuteNonQuery();
                db.Close();
            }
        }

        /// <summary>
        /// Initializare tabel
        /// </summary>
        /// <returns></returns>
        public static DataTable InitTable()
        {
            using DataTable? dt = new();
            dt.Columns.Add("Suma incasata de la client", typeof(float));
            dt.Columns.Add("Simbol1", typeof(string));
            dt.Columns.Add("Curs schimb", typeof(float));
            dt.Columns.Add("Suma platita clientului", typeof(float));
            dt.Columns.Add("Simbol2", typeof(string));

            return dt;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Warning", "Warning", MessageBoxButtons.OK);
            var v = sender.GetType();
            if (sender is DataGridView gridView)
            {
                gridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                gridView.RefreshEdit();
            }
        }
    }
}
