namespace Net07.DynamicProgrammingAndClasses
{
    class Rectangle : Square
    {
        public override double Area =>
            Point.GetDistance(Points[0], Points[1]) * 
            Point.GetDistance(Points[1], Points[2]);

        public override double Perimeter =>
            Point.GetDistance(Points[0], Points[1]) * 2 + 
            Point.GetDistance(Points[1], Points[2]) * 2;

        public Rectangle(Point a, Point b, Point c, Point d) : base(a, b, c, d) { }

        public Rectangle(Point[] array) : base(array) { }

        protected override bool Validation(params Point[] points)
        {
            double a = Point.GetDistance(points[0], points[1]);
            double b = Point.GetDistance(points[1], points[2]);
            double c = Point.GetDistance(points[2], points[3]);
            double d = Point.GetDistance(points[3], points[0]);
            return (a == c && b == d) && (a != b && c != d);
        }
    }
}