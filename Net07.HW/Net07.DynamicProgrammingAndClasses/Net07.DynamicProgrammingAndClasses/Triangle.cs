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
            //convertin cos to sin
            //var angle1 = Shape.AngleToRadians(25);
            //var angle2 = Shape.AngleToRadians(Math.Abs(25 - 90));
            //Console.WriteLine($"{Math.Sin(angle1)}    {Math.Cos(angle2)}");

            throw new NotImplementedException();
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