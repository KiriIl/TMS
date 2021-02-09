using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class Square : AngleShapes
    {
        Point[] points;
        public Square(Point a, Point b, Point c, Point d) : base(a, b, c, d) { }
        public Square(Point[] array) : base(array)
        {
            if (array.Length != 4)
            {
                throw new ArgumentException($"Недопустимое число точек задаваемых для {this}");
            }
        }
    }
}