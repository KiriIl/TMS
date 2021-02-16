using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            EfficientlyFibonacci(40);
            Square square = new Square(new Point[] { new Point(0, 0), new Point(0, 2), new Point(2, 2), new Point(2, 0) });
            Circle circle = new Circle(new Point(0, 0), 2);
            Ellipse ellipse = new Ellipse(new Point(5, 5), 4, 2);
            Logger logger = new FileLogger();
            logger.Log(ellipse);
        }

        private static void EfficientlyFibonacci(uint n)
        {
            uint[] buffer = new uint[n + 1];
            uint result = Fibonacci(n, buffer);
            Console.WriteLine(result);
        }

        private static uint Fibonacci(uint n, uint[] buffer)
        {
            if (n == 0 || n == 1)
            {
                buffer[n] = n;
                return n;
            }
            if (buffer[n] != default)
                return buffer[n];
            buffer[n] = Fibonacci(n - 1, buffer) + Fibonacci(n - 2, buffer);
            return Fibonacci(n - 1, buffer) + Fibonacci(n - 2, buffer);
        }
    }
}