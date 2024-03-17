using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    public class ConversionsDB
    {
        private const string dir = @"C:\C#\Files\";
        private const string path = dir + "Conversions.txt";
        private const string conversionDefaultPath = dir + "ConversionsDefault.txt";

        private static List<Conversion> conversions = null;

        public static List<Conversion> GetConversions()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            conversions = new List<Conversion>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split('|');
                Conversion conversion = new Conversion
                {
                    From = columns[0],
                    To = columns[1],
                    Multiplier = Convert.ToDecimal(columns[2])
                };
                conversions.Add(conversion);
            }

            textIn.Close();

            return conversions;
        }

        public static void RestoreDefaultConversions()
        {
            string fileContent = File.ReadAllText(conversionDefaultPath);
            File.WriteAllText(path, fileContent);
            
        }

        public static void SaveConversions(List<Conversion> conversions)
        {
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Conversion conversion in conversions)
            {
                textOut.Write(conversion.From + "|");
                textOut.Write(conversion.To + "|");
                textOut.WriteLine(conversion.Multiplier);
            }

            textOut.Close();
        }

        public static void AddConversion(Conversion conversion) {
            conversions.Add(conversion);
        }

        public static List<Conversion> RemoveConversion(Conversion conversion)
        {
            conversions.Remove(conversion);
            return conversions;

        }
    }
}
