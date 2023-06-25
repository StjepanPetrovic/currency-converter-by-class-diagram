using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_converter_by_class_diagram
{
    internal class Exchange
    {
        public ICurrencyConverter GetConverter(Currency fromCurrency, Currency toCurrency)
        {
            if (fromCurrency.Type == CurrencyType.Fiat && toCurrency.Type == CurrencyType.Fiat)
            {
                FiatConverter fiatConverter = new FiatConverter();

                return fiatConverter;
            }
            else if (fromCurrency.Type == CurrencyType.Fiat && toCurrency.Type == CurrencyType.Fiat)
            {
                CryptoConverter cryptoConverter = new CryptoConverter();

                return cryptoConverter;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        public double Convert(Currency fromCurrency, Currency toCurrency, double amount)
        {
            ICurrencyConverter converter = GetConverter(fromCurrency, toCurrency);

            return converter.Convert(fromCurrency, toCurrency, amount);
        }
    }
}
