using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net07.Operators
{
    class Program
    {
        const float EUR = 3.1762f;
        const float USD = 2.6293f;
        const float RUB = 0.0346f;
        const float BLR = 1.0000f;
        const float percentMarkup = 0.002f;
        static void Main(string[] args)
        {
            GetCurrencyEquivalent();
        }

        private static void GetCurrencyEquivalent()
        {
            Console.WriteLine("{0,20} {1,20}", "Банк покупает", "Банк продает");
            Console.WriteLine("{0,0} {1,15} {2,20}", nameof(EUR), EUR, EUR * (1 + percentMarkup));
            Console.WriteLine("{0,0} {1,15} {2,20}", nameof(USD), USD, USD * (1 + percentMarkup));
            Console.WriteLine("{0,0} {1,15} {2,20}", nameof(RUB), RUB, RUB * (1 + percentMarkup));
            //test
            float result = CalcCurrency(5, EUR, BLR);
            Console.WriteLine(result);
        }

        private static float CalcCurrency(float sum, float CurrencyIn, float CurrencyOut)
        {
            return sum * CurrencyIn / CurrencyOut;
        }
    }
}
