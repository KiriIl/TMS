namespace Net07.DynamicProgrammingAndClasses
{
    class Circle : Shape
    {
        public double Radius { get; }
        public Point Center { get; }
        public Circle(Point point)
        {
            Center = point;
        }
        public Circle(Point point, double radius) : this(point)
        {
            Radius = radius;
        }
    }
}