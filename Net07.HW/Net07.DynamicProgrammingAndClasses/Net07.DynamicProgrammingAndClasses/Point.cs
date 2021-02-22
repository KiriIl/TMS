using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class Point
    {
        public int X { get; }

        public int Y { get; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X({X}), Y({Y})";
        }

        public static double GetDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
    }
}