using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainApp
{
    internal class Helper
    {
        public static Form1? MainForm;
        public static string StartUpDirectory()
            => AppDomain.CurrentDomain.BaseDirectory;
        public static string DataBaseDirectory()
           => AppDomain.CurrentDomain.BaseDirectory + "Data\\" + "SQLite";
        public static string XMLDataDirectory()
          => AppDomain.CurrentDomain.BaseDirectory + "Data\\" + "XMLData\\";
        public static string DataDirectory()
          => AppDomain.CurrentDomain.BaseDirectory + "Data\\";
    }
}
