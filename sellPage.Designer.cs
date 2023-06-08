namespace mainApp
{
    partial class sellPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FristName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.Label();
            this.personFristName = new System.Windows.Forms.TextBox();
            this.personLastName = new System.Windows.Forms.TextBox();
            this.rezident = new System.Windows.Forms.Label();
            this.personRezident = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.personCountry = new System.Windows.Forms.TextBox();
            this.Series = new System.Windows.Forms.Label();
            this.Nr = new System.Windows.Forms.Label();
            this.personSeries = new System.Windows.Forms.TextBox();
            this.personNr = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CZKStock = new System.Windows.Forms.Label();
            this.CADStock = new System.Windows.Forms.Label();
            this.PLNStock = new System.Windows.Forms.Label();
            this.CHFStock = new System.Windows.Forms.Label();
            this.GBPStock = new System.Windows.Forms.Label();
            this.HUFStock = new System.Windows.Forms.Label();
            this.EURStock = new System.Windows.Forms.Label();
            this.USDStock = new System.Windows.Forms.Label();
            this.RONStock = new System.Windows.Forms.Label();
            this.CZK = new System.Windows.Forms.Label();
            this.CAD = new System.Windows.Forms.Label();
            this.PLN = new System.Windows.Forms.Label();
            this.CHF = new System.Windows.Forms.Label();
            this.GBP = new System.Windows.Forms.Label();
            this.HUF = new System.Windows.Forms.Label();
            this.EUR = new System.Windows.Forms.Label();
            this.USD = new System.Windows.Forms.Label();
            this.RON = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FristName
            // 
            this.FristName.AutoSize = true;
            this.FristName.Location = new System.Drawing.Point(39, 52);
            this.FristName.Name = "FristName";
            this.FristName.Size = new System.Drawing.Size(49, 15);
            this.FristName.TabIndex = 1;
            this.FristName.Text = "Numele";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 238);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 173);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(913, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(39, 78);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(64, 15);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Prenumele";
            // 
            // personFristName
            // 
            this.personFristName.Location = new System.Drawing.Point(122, 50);
            this.personFristName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personFristName.Name = "personFristName";
            this.personFristName.Size = new System.Drawing.Size(202, 23);
            this.personFristName.TabIndex = 4;
            // 
            // personLastName
            // 
            this.personLastName.Location = new System.Drawing.Point(122, 78);
            this.personLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personLastName.Name = "personLastName";
            this.personLastName.Size = new System.Drawing.Size(201, 23);
            this.personLastName.TabIndex = 5;
            // 
            // rezident
            // 
            this.rezident.AutoSize = true;
            this.rezident.Location = new System.Drawing.Point(39, 105);
            this.rezident.Name = "rezident";
            this.rezident.Size = new System.Drawing.Size(49, 15);
            this.rezident.TabIndex = 6;
            this.rezident.Text = "Rzident:";
            // 
            // personRezident
            // 
            this.personRezident.AutoSize = true;
            this.personRezident.Location = new System.Drawing.Point(122, 105);
            this.personRezident.Name = "personRezident";
            this.personRezident.Size = new System.Drawing.Size(13, 15);
            this.personRezident.TabIndex = 7;
            this.personRezident.Text = "F";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(39, 129);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(31, 15);
            this.Country.TabIndex = 8;
            this.Country.Text = "Tara:";
            // 
            // personCountry
            // 
            this.personCountry.Location = new System.Drawing.Point(122, 122);
            this.personCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personCountry.Name = "personCountry";
            this.personCountry.Size = new System.Drawing.Size(126, 23);
            this.personCountry.TabIndex = 9;
            // 
            // Series
            // 
            this.Series.AutoSize = true;
            this.Series.Location = new System.Drawing.Point(39, 154);
            this.Series.Name = "Series";
            this.Series.Size = new System.Drawing.Size(35, 15);
            this.Series.TabIndex = 10;
            this.Series.Text = "Seria:";
            // 
            // Nr
            // 
            this.Nr.AutoSize = true;
            this.Nr.Location = new System.Drawing.Point(39, 180);
            this.Nr.Name = "Nr";
            this.Nr.Size = new System.Drawing.Size(47, 15);
            this.Nr.TabIndex = 1;
            this.Nr.Text = "Numar:";
            // 
            // personSeries
            // 
            this.personSeries.Location = new System.Drawing.Point(122, 152);
            this.personSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personSeries.Name = "personSeries";
            this.personSeries.Size = new System.Drawing.Size(125, 23);
            this.personSeries.TabIndex = 11;
            // 
            // personNr
            // 
            this.personNr.Location = new System.Drawing.Point(121, 180);
            this.personNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personNr.Name = "personNr";
            this.personNr.Size = new System.Drawing.Size(126, 23);
            this.personNr.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CZKStock);
            this.panel2.Controls.Add(this.CADStock);
            this.panel2.Controls.Add(this.PLNStock);
            this.panel2.Controls.Add(this.CHFStock);
            this.panel2.Controls.Add(this.GBPStock);
            this.panel2.Controls.Add(this.HUFStock);
            this.panel2.Controls.Add(this.EURStock);
            this.panel2.Controls.Add(this.USDStock);
            this.panel2.Controls.Add(this.RONStock);
            this.panel2.Controls.Add(this.CZK);
            this.panel2.Controls.Add(this.CAD);
            this.panel2.Controls.Add(this.PLN);
            this.panel2.Controls.Add(this.CHF);
            this.panel2.Controls.Add(this.GBP);
            this.panel2.Controls.Add(this.HUF);
            this.panel2.Controls.Add(this.EUR);
            this.panel2.Controls.Add(this.USD);
            this.panel2.Controls.Add(this.RON);
            this.panel2.Location = new System.Drawing.Point(480, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 104);
            this.panel2.TabIndex = 12;
            // 
            // CZKStock
            // 
            this.CZKStock.AutoSize = true;
            this.CZKStock.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CZKStock.Location = new System.Drawing.Point(360, 59);
            this.CZKStock.Name = "CZKStock";
            this.CZKStock.Size = new System.Drawing.Size(13, 15);
            this.CZKStock.TabIndex = 17;
            this.CZKStock.Text = "0";
            // 
            // CADStock
            // 
            this.CADStock.AutoSize = true;
            this.CADStock.Location = new System.Drawing.Point(361, 44);
            this.CADStock.Name = "CADStock";
            this.CADStock.Size = new System.Drawing.Size(13, 15);
            this.CADStock.TabIndex = 16;
            this.CADStock.Text = "0";
            // 
            // PLNStock
            // 
            this.PLNStock.AutoSize = true;
            this.PLNStock.Location = new System.Drawing.Point(360, 29);
            this.PLNStock.Name = "PLNStock";
            this.PLNStock.Size = new System.Drawing.Size(13, 15);
            this.PLNStock.TabIndex = 15;
            this.PLNStock.Text = "0";
            // 
            // CHFStock
            // 
            this.CHFStock.AutoSize = true;
            this.CHFStock.Location = new System.Drawing.Point(205, 59);
            this.CHFStock.Name = "CHFStock";
            this.CHFStock.Size = new System.Drawing.Size(13, 15);
            this.CHFStock.TabIndex = 14;
            this.CHFStock.Text = "0";
            // 
            // GBPStock
            // 
            this.GBPStock.AutoSize = true;
            this.GBPStock.Location = new System.Drawing.Point(205, 44);
            this.GBPStock.Name = "GBPStock";
            this.GBPStock.Size = new System.Drawing.Size(13, 15);
            this.GBPStock.TabIndex = 13;
            this.GBPStock.Text = "0";
            // 
            // HUFStock
            // 
            this.HUFStock.AutoSize = true;
            this.HUFStock.Location = new System.Drawing.Point(205, 29);
            this.HUFStock.Name = "HUFStock";
            this.HUFStock.Size = new System.Drawing.Size(13, 15);
            this.HUFStock.TabIndex = 12;
            this.HUFStock.Text = "0";
            // 
            // EURStock
            // 
            this.EURStock.AutoSize = true;
            this.EURStock.Location = new System.Drawing.Point(49, 59);
            this.EURStock.Name = "EURStock";
            this.EURStock.Size = new System.Drawing.Size(13, 15);
            this.EURStock.TabIndex = 11;
            this.EURStock.Text = "0";
            // 
            // USDStock
            // 
            this.USDStock.AutoSize = true;
            this.USDStock.Location = new System.Drawing.Point(49, 44);
            this.USDStock.Name = "USDStock";
            this.USDStock.Size = new System.Drawing.Size(13, 15);
            this.USDStock.TabIndex = 10;
            this.USDStock.Text = "0";
            // 
            // RONStock
            // 
            this.RONStock.AutoSize = true;
            this.RONStock.Location = new System.Drawing.Point(49, 29);
            this.RONStock.Name = "RONStock";
            this.RONStock.Size = new System.Drawing.Size(13, 15);
            this.RONStock.TabIndex = 9;
            this.RONStock.Text = "0";
            // 
            // CZK
            // 
            this.CZK.AutoSize = true;
            this.CZK.Location = new System.Drawing.Point(322, 59);
            this.CZK.Name = "CZK";
            this.CZK.Size = new System.Drawing.Size(32, 15);
            this.CZK.TabIndex = 8;
            this.CZK.Text = "CZK:";
            // 
            // CAD
            // 
            this.CAD.AutoSize = true;
            this.CAD.Location = new System.Drawing.Point(322, 44);
            this.CAD.Name = "CAD";
            this.CAD.Size = new System.Drawing.Size(34, 15);
            this.CAD.TabIndex = 7;
            this.CAD.Text = "CAD:";
            // 
            // PLN
            // 
            this.PLN.AutoSize = true;
            this.PLN.Location = new System.Drawing.Point(322, 29);
            this.PLN.Name = "PLN";
            this.PLN.Size = new System.Drawing.Size(32, 15);
            this.PLN.TabIndex = 6;
            this.PLN.Text = "PLN:";
            // 
            // CHF
            // 
            this.CHF.AutoSize = true;
            this.CHF.Location = new System.Drawing.Point(164, 59);
            this.CHF.Name = "CHF";
            this.CHF.Size = new System.Drawing.Size(33, 15);
            this.CHF.TabIndex = 5;
            this.CHF.Text = "CHF:";
            // 
            // GBP
            // 
            this.GBP.AutoSize = true;
            this.GBP.Location = new System.Drawing.Point(164, 44);
            this.GBP.Name = "GBP";
            this.GBP.Size = new System.Drawing.Size(32, 15);
            this.GBP.TabIndex = 4;
            this.GBP.Text = "GBP:";
            // 
            // HUF
            // 
            this.HUF.AutoSize = true;
            this.HUF.Location = new System.Drawing.Point(164, 29);
            this.HUF.Name = "HUF";
            this.HUF.Size = new System.Drawing.Size(33, 15);
            this.HUF.TabIndex = 3;
            this.HUF.Text = "HUF:";
            // 
            // EUR
            // 
            this.EUR.AutoSize = true;
            this.EUR.Location = new System.Drawing.Point(10, 59);
            this.EUR.Name = "EUR";
            this.EUR.Size = new System.Drawing.Size(31, 15);
            this.EUR.TabIndex = 2;
            this.EUR.Text = "EUR:";
            // 
            // USD
            // 
            this.USD.AutoSize = true;
            this.USD.Location = new System.Drawing.Point(10, 44);
            this.USD.Name = "USD";
            this.USD.Size = new System.Drawing.Size(32, 15);
            this.USD.TabIndex = 1;
            this.USD.Text = "USD:";
            // 
            // RON
            // 
            this.RON.AutoSize = true;
            this.RON.Location = new System.Drawing.Point(10, 29);
            this.RON.Name = "RON";
            this.RON.Size = new System.Drawing.Size(35, 15);
            this.RON.TabIndex = 0;
            this.RON.Text = "RON:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(121, 212);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 22);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Adaugare";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // sellPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.personNr);
            this.Controls.Add(this.personSeries);
            this.Controls.Add(this.Nr);
            this.Controls.Add(this.Series);
            this.Controls.Add(this.personCountry);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.personRezident);
            this.Controls.Add(this.rezident);
            this.Controls.Add(this.personLastName);
            this.Controls.Add(this.personFristName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FristName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sellPage";
            this.Size = new System.Drawing.Size(923, 414);
            this.Load += new System.EventHandler(this.sellPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label rezident;
        private Label personRezident;
        private Label persoCountry;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Panel panel2;
        private Label CZK;
        private Label CAD;
        private Label PLN;
        private Label CHF;
        private Label GBP;
        private Label HUF;
        private Label EUR;
        private Label USD;
        private Label RON;
        private Label EURStock;
        private Label USDStock;
        private Label RONStock;
        private Label CZKStock;
        private Label CADStock;
        private Label PLNStock;
        private Label CHFStock;
        private Label GBPStock;
        private Label HUFStock;
        private Button AddButton;
        private Label FristName;
        private Label LastName;
        private Label Country;
        private TextBox personCountry;
        private Label Series;
        private Label Nr;
        private TextBox personFristName;
        private TextBox personLastName;
        private TextBox personSeries;
        private TextBox personNr;
    }
}
