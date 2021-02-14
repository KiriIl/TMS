namespace Net07.DynamicProgrammingAndClasses
{
    class Circle : Shape
    {
        public double Radius { get; }
        public Point Center { get; }

        public override double Area => throw new System.NotImplementedException();

        public override double Perimeter => throw new System.NotImplementedException();

        public Circle(Point point, double radius)
        {
            Center = point;
            Radius = radius;
        }

        protected override bool Validation(params Point[] point)
        {
            throw new System.NotImplementedException();
        }
    }
}