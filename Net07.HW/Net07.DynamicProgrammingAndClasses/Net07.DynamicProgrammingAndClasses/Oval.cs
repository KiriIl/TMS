using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class Oval : Circle
    {
        public double SmallRadius { get; }

        public override double Area => Math.PI * SmallRadius * Radius;

        public override double Perimeter =>
            Math.PI * 2 * Math.Sqrt((Math.Pow(SmallRadius, 2) + Math.Pow(Radius, 2)) / 2);

        public Oval(Point point, double bigRadius, double smallRadius) : base(point, bigRadius)
        {
            if (smallRadius >= bigRadius)
                throw new Exception($"Для фигуры {GetType().Name} малый радиус не может быть больше большого радиуса");
            SmallRadius = smallRadius;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {SmallRadius}";
        }
    }
}