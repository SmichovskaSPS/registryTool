using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Common
{
    /// <summary>
    /// Obsahuje metody používané vícero částmi projektu
    /// </summary>
    public class Common
    {
        // Vytvoří nový key - jestli již existuje, nic se neděje
        public static void CreateFile(string name, string text, string path)
        {
            try
            {
                FileStream stream = new FileStream(path + "/" + name + ".txt", FileMode.CreateNew);
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(text);
                writer.Close();
                stream.Close();
            }
            catch (Exception)
            {

            }
        }

        // Kontroluje, zda je hodnota textového řetězce 1 nebo 00000001 - užití u kontroly aktivace/deaktivace funkce v key
        public static bool IsOne(string path)
        {
            string text = File.ReadAllText(path);
            if (text == "1" || text == "00000001")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
