namespace Net07.DynamicProgrammingAndClasses
{
    class Point
    {
        public int X { set; get; }
        public int Y { set; get; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X({X}), Y({Y})";
        }
    }
}