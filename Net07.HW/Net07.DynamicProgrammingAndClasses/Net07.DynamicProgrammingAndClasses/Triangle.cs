using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class Triangle : AngleShapes
    {
        public Triangle(Point a, Point b, Point c) : base(a, b, c) { }
        public Triangle(Point[] array) : base(array)
        {
            if (array.Length != 3)
            {
                throw new ArgumentException($"Недопустимое число точек задаваемых для {this}");
            }
        }
    }
}