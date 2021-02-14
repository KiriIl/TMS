using System;

namespace Net07.DynamicProgrammingAndClasses
{
    abstract class Shape
    {
        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        public static double AngleToRadians(double angle)
        {
            return angle * Math.PI / 180;
        }

        public static double RadiansToAngle(double rad)
        {
            return rad * 180 / Math.PI;
        }

        protected abstract bool Validation(params Point[] points);
    }
}