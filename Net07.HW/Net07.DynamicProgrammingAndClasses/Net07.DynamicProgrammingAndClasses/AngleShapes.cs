using System;
using System.Text;

namespace Net07.DynamicProgrammingAndClasses
{
    abstract class AngleShapes : Shape
    {
        protected Point[] Points { get; }
        public AngleShapes(params Point[] array)
        {
            if (!Validation(array))
                throw new Exception($"Ввод не прошлел проверку для фигуры {GetType().Name}");
            Points = array;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var x in Points)
            {
                stringBuilder.AppendLine(x.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}