using System;

namespace TMS.Net07.HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int number, endProgrammNumber = 1;
            bool condition;
            do
            {
                Console.WriteLine("Input the number");
                str = Console.ReadLine();
            }
            while (!Int32.TryParse(str, out number));

            Console.WriteLine($"Your number is {number}");

            do
            {
                Console.WriteLine("Input the number to end programm");
                str = Console.ReadLine();
                condition = Int32.TryParse(str, out endProgrammNumber);
                if (!condition)
                    Console.WriteLine("Uncorrect input");
            }
            while (endProgrammNumber != 0 || !condition);
        }
    }
}
