using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class UserController
    {
        readonly string[] _typesOfShapes = 
        {
            nameof(Circle).ToLower(),
            nameof(Ellipse).ToLower(),
            nameof(Rectangle).ToLower(),
            nameof(Square).ToLower(),
            nameof(Triangle).ToLower()
        };

        public delegate void OnCreateShapeDelegate(Shape shape);
        public delegate void OnDrawShapeDelegate(int n);
        public delegate void OnListShapesDelegate();

        public event OnCreateShapeDelegate OnCreateShape;
        public event OnDrawShapeDelegate OnDrawShape;
        public event OnListShapesDelegate OnListShapes;

        public string ReadUserInput(string message)
        {
            Console.WriteLine(message);
            var inputString = Console.ReadLine();
            return inputString;
        }
        public void Controller()
        {
            var shapeType = ReadUserInput("Введите название фигуры на английском");
            var points = ReadUserInput("Введите точку(и) фигуры");
        }
    }
}
