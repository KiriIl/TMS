using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class Triangle : AngleShapes
    {
        public override double Area => CalcAreaForTriangle();

        public override double Perimeter =>
            Point.GetDistance(Points[0], Points[1]) +
            Point.GetDistance(Points[1], Points[2]) +
            Point.GetDistance(Points[2], Points[0]);

        public Triangle(Point a, Point b, Point c) : base(a, b, c) { }
        public Triangle(Point[] array) : base(array)
        {
            if (array.Length != 3)
            {
                throw new ArgumentException($"Недопустимое число точек задаваемых для {GetType().Name}");
            }
        }
        private double CalcAreaForTriangle()
        {
            double a = Point.GetDistance(Points[0], Points[1]);
            double b = Point.GetDistance(Points[1], Points[2]);
            double c = Point.GetDistance(Points[2], Points[0]);
            var cosAlpha = (a * a + c * c - b * b) / (2 * a * c);
            var angle = RadiansToAngle(Math.Acos(cosAlpha));
            return 0.5 * a * b * Math.Sin(AngleToRadians(angle));
        }

        protected override bool Validation(params Point[] points)
        {
            double a = Point.GetDistance(points[0], points[1]);
            double b = Point.GetDistance(points[1], points[2]);
            double c = Point.GetDistance(points[2], points[0]);
            return a + b > c && a + c > b && b + c > a;
        }
    }
}