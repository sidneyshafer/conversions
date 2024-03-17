using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    public class Conversion
    {
        public string From { get; set; } = "";
        public string To { get; set; } = "";
        public decimal Multiplier { get; set; } = 0;
        
        private string FullText;

        public string GetFullText()
        {
            FullText = From + "|" + To + "|" + Multiplier;
            return FullText;
        }

        public Conversion() { }

        public Conversion(string from, string to, decimal multiplier)
        {
            From = from;
            To = to;
            Multiplier = multiplier;
        }

        public string DisplayConversion(decimal value)
        {
            decimal result = value * Multiplier;
            return value + " " + From + " = " + result.ToString("F") + " " + To; 
        }

        override public string ToString()
        {
            return From + " to " + To;
        }
    }
}
