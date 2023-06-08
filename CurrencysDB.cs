using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using SQLite;
namespace mainApp
{
    class CurrencysDB
    {
        public CurrencysDB() { }
        public string Name { get; set; }
        public double Fixing { get; set; }
        public double SellPrice { get; set; }
        public double BuyPrice { get; set; }
        public string Symbol { get; set; }
        public double SellCom { get; set; }
        public double BuyCom { get; set; }
        

   
    }
}
