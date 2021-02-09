namespace Net07.DynamicProgrammingAndClasses
{
    class Rectangle : Square
    {
        public Rectangle(Point a, Point b, Point c, Point d) : base(a, b, c, d) { }
        public Rectangle(Point[] array) : base(array) { }
    }
}