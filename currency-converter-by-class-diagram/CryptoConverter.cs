using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_converter_by_class_diagram
{
    internal class CryptoConverter : ICurrencyConverter
    {
        public double Convert(Currency fromCurrency, Currency toCurrency, double amount)
        {
            return (fromCurrency.Rate / toCurrency.Rate) * amount * 0.95;
        }
    }
}
