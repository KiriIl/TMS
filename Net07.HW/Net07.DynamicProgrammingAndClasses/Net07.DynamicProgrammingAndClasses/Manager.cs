using System;
using System.Collections.Generic;

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

        public static void GetList()
        {
            Console.WriteLine("Logs:");
            foreach (var x in _shapes)
                Console.WriteLine(x);
        }

        public static Shape GetShape(int i)
        {
            return _shapes[i];
        }

        public static void DrawShape(int i, Logger drawer)
        {
            drawer.Log(_shapes[i]);
        }


        public static void GetLogs(Logger drawer)
        {
            Console.WriteLine("Logs:");
            foreach (var x in _shapes)
                drawer.Log(x);
        }

    }
}