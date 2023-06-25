using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_converter_by_class_diagram
{
    internal interface ICurrencyConverter
    {
        double Convert(Currency fromCurrency, Currency toCurrency, double amount);
    }
}
