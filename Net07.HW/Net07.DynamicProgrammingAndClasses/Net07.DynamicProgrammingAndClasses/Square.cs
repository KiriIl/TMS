using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class Square : AngleShapes
    {
        public override double Area => Math.Pow(Point.GetDistance(Points[0], Points[1]), 2);

        public override double Perimeter => Point.GetDistance(Points[0], Points[1]) * 4;

        public Square(Point a, Point b, Point c, Point d) : base(a, b, c, d) { }

        public Square(Point[] array) : base(array)
        {
            if (array.Length != 4)
            {
                throw new ArgumentException($"Недопустимое число точек задаваемых для {GetType().Name}");
            }
        }

        protected override bool Validation(params Point[] points)
        {
            double a = Point.GetDistance(points[0], points[1]);
            double b = Point.GetDistance(points[1], points[2]);
            double c = Point.GetDistance(points[2], points[3]);
            double d = Point.GetDistance(points[3], points[0]);
            // if any side of square bigger or lower then other sides by 0.00000...1, its not a square
            return a == b && b == c && c == d;
        }
    }
}