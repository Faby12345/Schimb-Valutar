namespace mainApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.loginControl = new mainApp.LoginCotrol();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveCurrencyTableBtn = new System.Windows.Forms.Button();
            this.currencyTabel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAddCurrencies = new System.Windows.Forms.GroupBox();
            this.btModifyCurrency = new System.Windows.Forms.Button();
            this.btSaveCurrency = new System.Windows.Forms.Button();
            this.btDelCurrency = new System.Windows.Forms.Button();
            this.lvCurrencies = new System.Windows.Forms.ListBox();
            this.btAddCurrency = new System.Windows.Forms.Button();
            this.tbCurrAmplification = new System.Windows.Forms.TextBox();
            this.lbCurrAmplif = new System.Windows.Forms.Label();
            this.tbCurrSymbol = new System.Windows.Forms.TextBox();
            this.lbCurrSymbol = new System.Windows.Forms.Label();
            this.tbCurrName = new System.Windows.Forms.TextBox();
            this.lbCurrName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sellPage2 = new mainApp.sellPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.dgvBuyTable = new System.Windows.Forms.DataGridView();
            this.dgvSellsTable = new System.Windows.Forms.DataGridView();
            this.dgvClientsTable = new System.Windows.Forms.DataGridView();
            this.dgvDBTable = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyTabel)).BeginInit();
            this.gbAddCurrencies.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Controls.Add(this.tabPage14);
            this.tabControl1.Controls.Add(this.tabPage15);
            this.tabControl1.Controls.Add(this.tabPage16);
            this.tabControl1.Controls.Add(this.tabPage17);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(38, 200);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 662);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            this.tabControl1.TabStop = false;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.loginControl);
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(916, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AUTENTIFICARE";
            // 
            // loginControl
            // 
            this.loginControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginControl.Location = new System.Drawing.Point(0, 0);
            this.loginControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(920, 658);
            this.loginControl.TabIndex = 0;
            this.loginControl.Load += new System.EventHandler(this.loginControl_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.saveCurrencyTableBtn);
            this.tabPage2.Controls.Add(this.currencyTabel);
            this.tabPage2.Controls.Add(this.gbAddCurrencies);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(916, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1. Modificare curs valutar";
            // 
            // saveCurrencyTableBtn
            // 
            this.saveCurrencyTableBtn.Location = new System.Drawing.Point(8, 379);
            this.saveCurrencyTableBtn.Name = "saveCurrencyTableBtn";
            this.saveCurrencyTableBtn.Size = new System.Drawing.Size(144, 34);
            this.saveCurrencyTableBtn.TabIndex = 10;
            this.saveCurrencyTableBtn.Text = "Salvare";
            this.saveCurrencyTableBtn.UseVisualStyleBackColor = true;
            this.saveCurrencyTableBtn.Click += new System.EventHandler(this.saveCurrencyTableBtn_Click);
            // 
            // currencyTabel
            // 
            this.currencyTabel.AllowDrop = true;
            this.currencyTabel.AllowUserToAddRows = false;
            this.currencyTabel.AllowUserToDeleteRows = false;
            this.currencyTabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.currencyTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currencyTabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column7,
            this.Column5});
            this.currencyTabel.Location = new System.Drawing.Point(6, 172);
            this.currencyTabel.Name = "currencyTabel";
            this.currencyTabel.RowTemplate.Height = 25;
            this.currencyTabel.Size = new System.Drawing.Size(914, 194);
            this.currencyTabel.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NUME";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SIMBOL";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "C_CUMPARARE";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "COMIS_C";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "C_VANZAREA";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "COMIS_V";
            this.Column7.Name = "Column7";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "C_FIXING";
            this.Column5.Name = "Column5";
            // 
            // gbAddCurrencies
            // 
            this.gbAddCurrencies.Controls.Add(this.btModifyCurrency);
            this.gbAddCurrencies.Controls.Add(this.btSaveCurrency);
            this.gbAddCurrencies.Controls.Add(this.btDelCurrency);
            this.gbAddCurrencies.Controls.Add(this.lvCurrencies);
            this.gbAddCurrencies.Controls.Add(this.btAddCurrency);
            this.gbAddCurrencies.Controls.Add(this.tbCurrAmplification);
            this.gbAddCurrencies.Controls.Add(this.lbCurrAmplif);
            this.gbAddCurrencies.Controls.Add(this.tbCurrSymbol);
            this.gbAddCurrencies.Controls.Add(this.lbCurrSymbol);
            this.gbAddCurrencies.Controls.Add(this.tbCurrName);
            this.gbAddCurrencies.Controls.Add(this.lbCurrName);
            this.gbAddCurrencies.Location = new System.Drawing.Point(0, 0);
            this.gbAddCurrencies.Name = "gbAddCurrencies";
            this.gbAddCurrencies.Size = new System.Drawing.Size(373, 120);
            this.gbAddCurrencies.TabIndex = 8;
            this.gbAddCurrencies.TabStop = false;
            this.gbAddCurrencies.Text = "Adaugare Monede";
            // 
            // btModifyCurrency
            // 
            this.btModifyCurrency.Location = new System.Drawing.Point(89, 85);
            this.btModifyCurrency.Name = "btModifyCurrency";
            this.btModifyCurrency.Size = new System.Drawing.Size(78, 23);
            this.btModifyCurrency.TabIndex = 15;
            this.btModifyCurrency.Text = "Modificare";
            this.btModifyCurrency.UseVisualStyleBackColor = true;
            this.btModifyCurrency.Click += new System.EventHandler(this.btModifyCurrency_Click);
            // 
            // btSaveCurrency
            // 
            this.btSaveCurrency.Location = new System.Drawing.Point(173, 85);
            this.btSaveCurrency.Name = "btSaveCurrency";
            this.btSaveCurrency.Size = new System.Drawing.Size(100, 23);
            this.btSaveCurrency.TabIndex = 14;
            this.btSaveCurrency.Text = "Salvare";
            this.btSaveCurrency.UseVisualStyleBackColor = true;
            this.btSaveCurrency.Click += new System.EventHandler(this.btSaveCurrency_Click);
            // 
            // btDelCurrency
            // 
            this.btDelCurrency.Location = new System.Drawing.Point(279, 85);
            this.btDelCurrency.Name = "btDelCurrency";
            this.btDelCurrency.Size = new System.Drawing.Size(88, 23);
            this.btDelCurrency.TabIndex = 13;
            this.btDelCurrency.Text = "Stergere";
            this.btDelCurrency.UseVisualStyleBackColor = true;
            this.btDelCurrency.Click += new System.EventHandler(this.btDelCurrency_Click);
            // 
            // lvCurrencies
            // 
            this.lvCurrencies.FormattingEnabled = true;
            this.lvCurrencies.ItemHeight = 15;
            this.lvCurrencies.Location = new System.Drawing.Point(268, 19);
            this.lvCurrencies.Name = "lvCurrencies";
            this.lvCurrencies.Size = new System.Drawing.Size(101, 64);
            this.lvCurrencies.TabIndex = 9;
            this.lvCurrencies.SelectedIndexChanged += new System.EventHandler(this.lvCurrencies_SelectedIndexChanged);
            // 
            // btAddCurrency
            // 
            this.btAddCurrency.Location = new System.Drawing.Point(6, 85);
            this.btAddCurrency.Name = "btAddCurrency";
            this.btAddCurrency.Size = new System.Drawing.Size(77, 23);
            this.btAddCurrency.TabIndex = 12;
            this.btAddCurrency.Text = "Adaugare";
            this.btAddCurrency.UseVisualStyleBackColor = true;
            this.btAddCurrency.Click += new System.EventHandler(this.btAddCurrency_Click);
            // 
            // tbCurrAmplification
            // 
            this.tbCurrAmplification.Location = new System.Drawing.Point(80, 56);
            this.tbCurrAmplification.Name = "tbCurrAmplification";
            this.tbCurrAmplification.Size = new System.Drawing.Size(72, 23);
            this.tbCurrAmplification.TabIndex = 11;
            this.tbCurrAmplification.Text = "0";
            // 
            // lbCurrAmplif
            // 
            this.lbCurrAmplif.AutoSize = true;
            this.lbCurrAmplif.Location = new System.Drawing.Point(6, 59);
            this.lbCurrAmplif.Name = "lbCurrAmplif";
            this.lbCurrAmplif.Size = new System.Drawing.Size(68, 15);
            this.lbCurrAmplif.TabIndex = 10;
            this.lbCurrAmplif.Text = "Amplificare";
            // 
            // tbCurrSymbol
            // 
            this.tbCurrSymbol.Location = new System.Drawing.Point(212, 19);
            this.tbCurrSymbol.Name = "tbCurrSymbol";
            this.tbCurrSymbol.Size = new System.Drawing.Size(50, 23);
            this.tbCurrSymbol.TabIndex = 9;
            // 
            // lbCurrSymbol
            // 
            this.lbCurrSymbol.AutoSize = true;
            this.lbCurrSymbol.Location = new System.Drawing.Point(162, 22);
            this.lbCurrSymbol.Name = "lbCurrSymbol";
            this.lbCurrSymbol.Size = new System.Drawing.Size(44, 15);
            this.lbCurrSymbol.TabIndex = 8;
            this.lbCurrSymbol.Text = "Simbol";
            // 
            // tbCurrName
            // 
            this.tbCurrName.Location = new System.Drawing.Point(56, 19);
            this.tbCurrName.Name = "tbCurrName";
            this.tbCurrName.Size = new System.Drawing.Size(100, 23);
            this.tbCurrName.TabIndex = 7;
            // 
            // lbCurrName
            // 
            this.lbCurrName.AutoSize = true;
            this.lbCurrName.Location = new System.Drawing.Point(6, 22);
            this.lbCurrName.Name = "lbCurrName";
            this.lbCurrName.Size = new System.Drawing.Size(40, 15);
            this.lbCurrName.TabIndex = 6;
            this.lbCurrName.Text = "Nume";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sellPage2);
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage3.Size = new System.Drawing.Size(916, 654);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2. Vanzare valuta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sellPage2
            // 
            this.sellPage2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellPage2.Location = new System.Drawing.Point(0, -4);
            this.sellPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellPage2.Name = "sellPage2";
            this.sellPage2.Size = new System.Drawing.Size(924, 454);
            this.sellPage2.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(204, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(916, 654);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "3. Cumparare Valuta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(204, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(916, 654);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "4. Evidenta solduri in lei";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(204, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(916, 654);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "5. Istoric cursuri de schimb";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(204, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(916, 654);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "6. Listari/Tipariri utile";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(204, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(916, 654);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "7. Registru casa in lei";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(204, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(916, 654);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "8. Registru casa in valuta";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(204, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(916, 654);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "9. Refac calculele pe ziua curenta";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(204, 4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(916, 654);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "10. Centralizare operatiun vanz/cump";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(204, 4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(916, 654);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "11. Raport contabil pe luna";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(204, 4);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(916, 654);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "12. Casa fiscala";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(204, 4);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(916, 654);
            this.tabPage14.TabIndex = 13;
            this.tabPage14.Text = "13. Setari";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(204, 4);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(916, 654);
            this.tabPage15.TabIndex = 14;
            this.tabPage15.Text = "14. Raport BNR";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.Location = new System.Drawing.Point(204, 4);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(916, 654);
            this.tabPage16.TabIndex = 15;
            this.tabPage16.Text = "15. Solduri";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.dgvBuyTable);
            this.tabPage17.Controls.Add(this.dgvSellsTable);
            this.tabPage17.Controls.Add(this.dgvClientsTable);
            this.tabPage17.Controls.Add(this.dgvDBTable);
            this.tabPage17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage17.Location = new System.Drawing.Point(204, 4);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(916, 654);
            this.tabPage17.TabIndex = 16;
            this.tabPage17.Text = "Useri";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // dgvBuyTable
            // 
            this.dgvBuyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuyTable.Location = new System.Drawing.Point(3, 471);
            this.dgvBuyTable.Name = "dgvBuyTable";
            this.dgvBuyTable.RowTemplate.Height = 25;
            this.dgvBuyTable.Size = new System.Drawing.Size(831, 150);
            this.dgvBuyTable.TabIndex = 7;
            // 
            // dgvSellsTable
            // 
            this.dgvSellsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellsTable.Location = new System.Drawing.Point(3, 315);
            this.dgvSellsTable.Name = "dgvSellsTable";
            this.dgvSellsTable.RowTemplate.Height = 25;
            this.dgvSellsTable.Size = new System.Drawing.Size(831, 150);
            this.dgvSellsTable.TabIndex = 6;
            // 
            // dgvClientsTable
            // 
            this.dgvClientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsTable.Location = new System.Drawing.Point(3, 159);
            this.dgvClientsTable.Name = "dgvClientsTable";
            this.dgvClientsTable.RowTemplate.Height = 25;
            this.dgvClientsTable.Size = new System.Drawing.Size(831, 150);
            this.dgvClientsTable.TabIndex = 5;
            // 
            // dgvDBTable
            // 
            this.dgvDBTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBTable.Location = new System.Drawing.Point(3, 3);
            this.dgvDBTable.Name = "dgvDBTable";
            this.dgvDBTable.RowTemplate.Height = 25;
            this.dgvDBTable.Size = new System.Drawing.Size(831, 150);
            this.dgvDBTable.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 662);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencyTabel)).EndInit();
            this.gbAddCurrencies.ResumeLayout(false);
            this.gbAddCurrencies.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private LoginCotrol loginControl;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private TabPage tabPage14;
        private TabPage tabPage15;
        private TabPage tabPage16;
        private TabPage tabPage17;
        public DataGridView dgvBuyTable;
        public DataGridView dgvSellsTable;
        public DataGridView dgvClientsTable;
        public DataGridView dgvDBTable;
        private GroupBox gbAddCurrencies;
        private TextBox tbCurrAmplification;
        private Label lbCurrAmplif;
        private TextBox tbCurrSymbol;
        private Label lbCurrSymbol;
        private TextBox tbCurrName;
        private Label lbCurrName;
        private ListBox lvCurrencies;
        private Button btAddCurrency;
        private Button btDelCurrency;
        private Button btSaveCurrency;
        private Button btModifyCurrency;
        private sellPage sellPage2;
        private DataGridView currencyTabel;
        private Button saveCurrencyTableBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
    }
}