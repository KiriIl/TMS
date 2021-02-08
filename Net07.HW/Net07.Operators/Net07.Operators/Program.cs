using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

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
        static double markUpUSD = Math.Round(USD * PERCENTTMARKUP, 4);
        static double markUpRUB = Math.Round(RUB * PERCENTTMARKUP, 4);
        const double FI = 1.6180339887d;
        const string patternBinary = @"(?i)(^\d{1,})\s{0,}(pow|\+|\-|\/|\*|\%)\s{0,}(\d{1,}$)";
        const string patternUnary = @"(?i)^(sqrt|sqr)\s{0,}(\d{1,})";

        static void Main(string[] args)
        {
            GetCurrencyEquivalent();
            Operation();
            Console.WriteLine(Fibonacci(40));
            Console.WriteLine(EfficientlyFibonacci(40));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(FactorialCycle(5));
        }

        private static void Operation()
        {
            try
            {
                Regex regexBinary = new Regex(patternBinary);
                Regex regexUnary = new Regex(patternUnary);
                Console.WriteLine("Введите строку для выполнения операции");
                string inputString = Console.ReadLine();
                double result;
                string operation;
                int operand1, operand2;
                if (regexBinary.IsMatch(inputString))
                {
                    var temp = regexBinary.Split(inputString);
                    operand1 = int.Parse(temp[1]);
                    operation = temp[2];
                    operand2 = int.Parse(temp[3]);
                    result = ExecuteOperation(operation, operand1, operand2);
                }
                else if (regexUnary.IsMatch(inputString))
                {
                    var temp = regexUnary.Split(inputString);
                    operation = temp[1];
                    operand1 = int.Parse(temp[2]);
                    result = ExecuteOperation(operation, operand1);
                }
                else
                {
                    Console.WriteLine("Недопустимая операция");
                    return;
                }
                Console.WriteLine(result);
            }
            catch (FormatException) { Console.WriteLine("Ошибка ввода строки"); }
        }

        private static double ExecuteOperation(string operation, int operand1, int operand2 = 0)
        {
            switch (operation)
            {
                case "+": return operand1 + operand2;
                case "-": return operand1 - operand2;
                case "/": return operand1 / operand2;
                case "*": return operand1 * operand2;
                case "%": return operand1 % operand2;
                case "pow": return Math.Pow(operand1, operand2);
                case "sqr": return Math.Pow(operand1, 2);
                case "sqrt": return Math.Sqrt(operand1);
                default: return default;
            }
        }

        private static uint FactorialCycle(uint n)
        {
            uint k = 1;
            for (uint i = 1; i <= n; i++)
                k *= i;
            return k;
        }

        private static uint Factorial(uint n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return Factorial(n - 1) * n;
        }

        private static uint Fibonacci(uint n)
        {
            if (n == 0)
                return 0;
            else if (n == 1 || n == 2)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private static uint EfficientlyFibonacci(uint n)
        {
            if (n == 0)
                return 0;
            else if (n == 1 || n == 2)
                return 1;
            else
                return Convert.ToUInt32(EfficientlyFibonacci(n - 1) * FI);
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
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine(CalcCurrency(sum, GetCurrencyValue(convertFrom, false), GetCurrencyValue(convertTo, true)));
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