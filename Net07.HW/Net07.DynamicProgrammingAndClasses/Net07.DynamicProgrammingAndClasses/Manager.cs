using System;
using System.Collections.Generic;
using System.Text;

namespace Net07.DynamicProgrammingAndClasses
{
    static class Manager
    {
        static List<Shape> _shapes;
        public static int count;
        static Manager()
        {
            _shapes = new List<Shape>();
            count = 0;
        }

        public static void AddItem(Shape item)
        {
            _shapes.Add(item);
        }

        public static void GetLogs()
        {
            Console.WriteLine("Logs:");
            foreach (var x in _shapes)
                Console.WriteLine(x);
        }

        public static void GetLogs(Logger drawer)
        {
            foreach (var x in _shapes)
                drawer.Log(x);
        }

        public static Shape GetShape(int i)
        {
            if (i > count)
                throw new IndexOutOfRangeException("Такой фигуры в списке нету");
            return _shapes[i];
        }

        public static void DrawShape(int i, Logger drawer) => drawer.Log(_shapes[i]);
    }
}