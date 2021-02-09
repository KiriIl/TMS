using System.Text;

namespace Net07.DynamicProgrammingAndClasses
{
    class AngleShapes : Shape
    {
        Point[] Points { get; }
        public AngleShapes(params Point[] array)
        {
            Points = array;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var x in Points)
            {
                stringBuilder.Append(x + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}