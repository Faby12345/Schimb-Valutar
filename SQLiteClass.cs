
using System.Data;
using System.Data.SQLite;

namespace mainApp
{
    internal class SQLiteClass
    {
        private SQLiteConnection? sqlConn;
        private SQLiteCommand? sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter? DB;
        private string DbPath = string.Empty;
        public SQLiteClass() => SetConnection();

        /// <summary>
        /// Get users data base path and set SQLite connection
        /// </summary>
        private void SetConnection()
        {
            string path = Helper.DataBaseDirectory();
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            DbPath = Helper.DataBaseDirectory() + "\\UsersDB.db";
            if (File.Exists(DbPath))
            {
                sqlConn = new SQLiteConnection("Data Source =" + DbPath,true);
            }
            else
            {
                sqlConn = new SQLiteConnection("Data Source =" + DbPath);

                CreateUsersTable();
                CreateClientsTable();
                CreateEVTable();
                CreateBuyTable();
               

                string Command = "Insert into Users (UserName,UserPassword,IsAdmin)" +
                "values('Radmin','123','1')";
                ExecuteQuery(Command,"Users");

                sqlConn.Close();
            }
            //Helper.MainForm.dgvDBTable.DataSource = LoadData();

        }
        /// <summary>
        /// Execute sql given command.
        /// </summary>
        /// <param name="sqlCommand">sql commad to be executed</param>
        /// <param name="table">db table</param>
        public void ExecuteQuery(string sqlCommand,string table)
        {
            SetConnection();
            sqlConn?.Open();
            sqlCmd = sqlConn?.CreateCommand();
            sqlCmd.CommandText = sqlCommand;
            sqlCmd.ExecuteNonQuery();
            sqlCmd.Dispose();
            sqlConn?.Close();
            Helper.MainForm.dgvDBTable.DataSource = LoadData(table);

        }
        public DataView LoadData(string table)
        {
            if (sqlConn is null)
                SetConnection();
            sqlCmd = sqlConn?.CreateCommand();
            string CommandText = "select * from " + table;
            DB = new SQLiteDataAdapter(CommandText, sqlConn);
            DS.Reset();
            DB.Fill(DS);
            sqlDT = DS.Tables[0];
            sqlConn.Close();

            return sqlDT.DefaultView;
        }
        void CreateUsersTable()
        {
            if(sqlConn.State != ConnectionState.Open) 
                sqlConn.Open();
           
            if(sqlCmd == null) 
                sqlCmd = sqlConn.CreateCommand();
            
            string CommandText = "CREATE TABLE Users" +
                     "(UserName CHAR(50)," +
                     "UserPassword CHAR(50)," +
                     "IsAdmin INTEGER)";

            DB = new SQLiteDataAdapter(CommandText, sqlConn);
            DS.Reset();
            DB.Fill(DS);
        }
        void CreateClientsTable()
        {
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();

            if (sqlCmd == null)
                sqlCmd = sqlConn.CreateCommand();

            string CommandText = "CREATE TABLE Clients(" +
                        "Indexer INTEGER," +
                        "FirstName CHAR(50)," +
                        "LastName CHAR(50)," +
                        "FullName CHAR(50)," +
                        "Rezident CHAR(50)," +
                        "Country CHAR(50)," +
                        "Series CHAR(50)," +
                        "IdNumber INTEGER)";
            DB = new SQLiteDataAdapter(CommandText, sqlConn);
            DS.Reset();
            DB.Fill(DS);
        }
        void CreateEVTable() /// TODO: save monthly ( ex: EV012022 )
        {
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();

            if (sqlCmd == null)
                sqlCmd = sqlConn.CreateCommand();

            string CommandText = "CREATE TABLE EV(" +
                        //"TransactionNumber INTEGER," +
                        "Date CHAR(50)," +
                        "TransNr INTEGER," +
                        "OperationNr INTEGER," +
                        "ClientName CHAR(50)," +
                        "Type CHAR(10)," +
                        "Counry CHAR(50)," +
                        "Rezident CHAR(50)," +
                        "SerieAct CHAR(50)," +
                        "NrAct INTEGER," +
                        "Symbol CHAR(50)," +
                        "Curs INTEGER," +
                        "Sum INTEGER," +
                        "Value INTEGER," +
                        "Fisal INTEGER," +
                        "Casier CHAR(50))";
            DB = new SQLiteDataAdapter(CommandText, sqlConn);
            DS.Reset();
            DB.Fill(DS);
        }
        void CreateBuyTable() /// TODO: delete
        {
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();

            if (sqlCmd == null)
                sqlCmd = sqlConn.CreateCommand();

            string CommandText = "CREATE TABLE Purchases(" +
                        //"TransactionNumber INTEGER," +
                        "CashIn INTEGER," +
                        "SymbolIn CHAR(50)," +
                        "BuyPrice INTEGER," +
                        "CashOut INTEGER," +
                        "SymbolOut CHAR(50)," +
                        "Date CHAR(50))";
            DB = new SQLiteDataAdapter(CommandText, sqlConn);
            DS.Reset();
            DB.Fill(DS);
        }
    }
}
