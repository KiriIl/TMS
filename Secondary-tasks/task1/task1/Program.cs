using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            CounterClass[] counterClasses = new CounterClass[75];
            for (int i = 0; i < counterClasses.Length; i++)
            {
                counterClasses[i] = new CounterClass();
            }
            CounterClass counter = new CounterClass();
            CounterClass counter1 = new CounterClass();
            CounterClass counter2 = new CounterClass();

            Console.WriteLine(CounterClass.Counter);
            Console.WriteLine(counter.NonStaticCounter);

            Safe<string> safe = new Safe<string>("da");
            Safe<int> safe1 = new Safe<int>(5);
            Safe<char> safe2 = new Safe<char>('r');
            Console.WriteLine(safe.Value);
            Console.WriteLine(safe1.Value);
            Console.WriteLine(safe2.Value);

            Duck[] ducks = new Duck[10];
            for (int i = 0; i < ducks.Length; i++)
                ducks[i] = DuckManager.RandomDuck();
            foreach (var x in ducks)
                Console.WriteLine(x.Quac);
        }
    }
}
