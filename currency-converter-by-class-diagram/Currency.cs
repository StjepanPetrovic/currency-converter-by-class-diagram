using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace currency_converter_by_class_diagram
{
    public enum CurrencyType
    {
        Fiat,
        Crypto,
    }

    public class Currency
    {
        public string Name { get; set; }
        public CurrencyType Type { get; set; }
        public double Rate { get; set; }

        public Currency(string name, CurrencyType type, double rate)
        {
            Name = name;
            Type = type;
            Rate = rate;
        }
    }
}
