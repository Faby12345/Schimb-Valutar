using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace mainApp
{
    internal class XMLFunctions
    {

        public static void ReadCurrencyValues()
        {
            string path = Helper.XMLDataDirectory() + "Monede.xml";

            try
            {
                if (!File.Exists(path)) Currency.CurrencyList = new ObservableCollection<Currency> {};

                XmlSerializer serializer = new(typeof(ObservableCollection<Currency>));
                StringReader strReader = new(File.ReadAllText(path));

                using (XmlReader reader = XmlReader.Create(strReader))
                {
                    Currency.CurrencyList = (ObservableCollection<Currency>)serializer.Deserialize(reader);

                    foreach (Currency bench in Currency.CurrencyList)
                    {

                    }
                }
            }
            catch
            {
                Currency.CurrencyList = new ObservableCollection<Currency> { };
            }
        }
        public static void WriteCurrencyValues()
        {
            string path = Helper.XMLDataDirectory()+ "Monede.xml";
            if (!Directory.Exists(Helper.DataDirectory())) Directory.CreateDirectory(Helper.DataDirectory());
            if (!Directory.Exists(Helper.XMLDataDirectory())) Directory.CreateDirectory(Helper.XMLDataDirectory());

            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Currency>));
            StringWriter strWriter = new StringWriter();
            XmlWriterSettings xmlSettings = new XmlWriterSettings
            {
                Indent = true
            };

            using (XmlWriter writer = XmlWriter.Create(strWriter, xmlSettings))
            {
                serializer.Serialize(writer, Currency.CurrencyList);
                File.WriteAllText(path, strWriter.ToString());
            }
        }
    }
}
