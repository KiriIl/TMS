using System;

namespace Net07.Operators
{
    class Program
    {
        enum Currency
        {
            EUR,
            USD,
            RUB,
            BYN
        }

        const double EUR = 3.1762d;
        const double USD = 2.6293d;
        const double RUB = 0.0346d;
        const double BYN = 1.0000d;
        const double PERCENTTMARKUP = 1.002d;
        static double markUpEUR = Math.Round(EUR * PERCENTTMARKUP, 4);
        static double markUpUSD= Math.Round(USD * PERCENTTMARKUP, 4);
        static double markUpRUB = Math.Round(RUB * PERCENTTMARKUP, 4);

        static void Main(string[] args)
        {
            GetCurrencyEquivalent();
        }

        private static void GetCurrencyEquivalent()
        {
            Currency convertFrom, convertTo;
            Console.WriteLine("{0,25} {1,25}", "Стоимость продажи", "Стоимость покупки");
            Console.WriteLine("{0,0} {1,15} {2,20}", nameof(EUR), EUR, markUpEUR);
            Console.WriteLine("{0,0} {1,15} {2,20}", nameof(USD), USD, markUpUSD);
            Console.WriteLine("{0,0} {1,15} {2,20}", nameof(RUB), RUB, markUpRUB);
            convertFrom = GetCurrencyByInput();
            convertTo = GetCurrencyByInput();
            double result = CalcCurrency(100, GetCurrencyValue(convertFrom, false), GetCurrencyValue(convertTo, true));
            Console.WriteLine(result);
        }

        private static Currency GetCurrencyByInput()
        {
            Console.WriteLine("Введите код валюты");
            string inputString = Console.ReadLine();
            switch (inputString.ToUpper())
            {
                case nameof(Currency.EUR): return Currency.EUR;
                case nameof(Currency.USD): return Currency.USD;
                case nameof(Currency.RUB): return Currency.RUB;
                case nameof(Currency.BYN): return Currency.BYN;
            }
            return default;
        }
        private static double GetCurrencyValue(Currency currency, bool buy)
        {
            switch (currency)
            {
                case Currency.EUR when buy: return markUpEUR;
                case Currency.EUR when !buy: return EUR;
                case Currency.USD when buy: return markUpUSD;
                case Currency.USD when !buy: return USD;
                case Currency.RUB when buy: return markUpRUB;
                case Currency.RUB when !buy: return RUB;
                case Currency.BYN: return BYN;
                default: return default;
            }
        }
        private static double CalcCurrency(double sum, double CurrencyIn, double CurrencyOut)
        {
            Console.WriteLine($"{CurrencyIn}     {CurrencyOut}");
            return Math.Round(sum * CurrencyIn / CurrencyOut, 2);
        }
    }
}
