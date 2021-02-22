using System;
using System.Text.RegularExpressions;

namespace Net07.DynamicProgrammingAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //пытался делать интерфейс пользователя, ни никакне получалось + на работе мозги кипят, так что есть только класс для работы с фигурами Manager
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger();
            Square square = new Square(new Point[] { new Point(0, 0), new Point(0, 2), new Point(2, 2), new Point(2, 0) });
            Rectangle rectangle = new Rectangle(new Point[] { new Point(0, 0), new Point(0, 2), new Point(4, 2), new Point(4, 0) });
            Triangle triangle = new Triangle(new Point[] { new Point(0, 0), new Point(0, 2), new Point(2, 0) });
            Circle circle = new Circle(new Point(0, 0), 2);
            Ellipse ellipse = new Ellipse(new Point(0, 0), 2, 1);
            Manager.AddItem(square);
            Manager.AddItem(rectangle);
            Manager.AddItem(triangle);
            Manager.AddItem(circle);
            Manager.AddItem(ellipse);
            Manager.GetLogs();
            Manager.DrawShape(5, consoleLogger);

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