using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mainApp
{
    public class ClientClass
    {
        public ClientClass() { }

        public string FristName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public bool Resident { get; set; }
        public string Country { get; set; }
        public string Series { get; set; }
        public int Number { get; set; }

        public List<SellItem> SellItems = new List<SellItem>();
        public List<BuyItem> BuyItems = new List<BuyItem>();
    }
    public class SellItem
    {
        public SellItem() { }

        public double CashIn { get; set; }
        public string SymbolIn { get; set; }
        public double SellPrice { get; set; }
        public double CashOut { get; set; }
        public string SymbolOut { get; set; }
        public DateTime TimeOfSell { get; set; }    
    }
    public class BuyItem
    {
        public BuyItem() { }

        public double CashIn { get; set; }
        public string SymbolIn { get; set; }
        public double BuyPrice { get; set; }
        public double CashOut { get; set; }
        public string SymbolOut { get; set; }
        public DateTime TimeOfBuy { get; set; }
    }
    
    public class Currency
    {
        [XmlAttribute("Nume")]
        public string Name { get; set; }
        [XmlAttribute("Symbol")]
        public string Symbol { get; set; }
        [XmlIgnore]
        public double ExactValue { get; set; }
        [XmlIgnore]
        public double SellPrice { get; set; }
        [XmlIgnore]
        public double BuyPrice { get; set; }
        [XmlAttribute("Amplification")]
        public float Amplification { get; set;}

        [XmlArray]
        public static ObservableCollection<Currency> CurrencyList;
        public Currency(){ }
        public Currency(string name,string symbol,float amplif)
        {
            Name = name;
            Symbol = symbol;
            Amplification = amplif;
        }
    }
    public class Currency1
    {
        public Currency1() { }   
        public string Name { get; set; }
        public double fixing { get; set; }
        public double sellPrice { get; set; }
        public double buyPrice { get; set; }
        public string symbol { get; set; }
        public double sellCom { get; set; }
        public double buyCom { get; set; }

    }

}
