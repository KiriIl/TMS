namespace Net07.DynamicProgrammingAndClasses
{
    class Oval : Circle
    {
        public double SmallRadius { get; }

        public Oval(Point point, double bigRadius, double smallRadius) : base(point, bigRadius)
        {
            SmallRadius = smallRadius;
        }
    }
}