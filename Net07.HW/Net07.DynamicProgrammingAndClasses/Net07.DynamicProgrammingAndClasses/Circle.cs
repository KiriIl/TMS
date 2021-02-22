using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class Circle : Shape
    {
        public double Radius { get; }
        public Point Center { get; }

        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public override double Perimeter => 2 * Math.PI * Radius;

        public Circle(Point point, double radius)
        {
            if (radius < 0)
                throw new Exception($"Для фигуры {GetType().Name} радиус задан отрицательно");
            Center = point;
            Radius = radius;
        }

        protected override bool Validation(params Point[] point)
        {
            return true;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {Center}, {Radius}";
        }
    }
}