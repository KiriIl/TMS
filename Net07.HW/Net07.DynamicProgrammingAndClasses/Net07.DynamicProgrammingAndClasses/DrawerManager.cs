using System;
using System.Collections.Generic;

namespace Net07.DynamicProgrammingAndClasses
{
    static class DrawerManager
    {
        static List<Shape> _shapes;
        public static int count;
        static DrawerManager()
        {
            _shapes = new List<Shape>();
            count = 0;
        }
        public static Shape GetShape(int i)
        {
            return _shapes[i];
        }

        public static void DrawShape(int i, Drawer drawer)
        {
            drawer.Draw(_shapes[i]);
        }

        public static void GetLogs()
        {
            Console.WriteLine("Logs:");
            foreach (var x in _shapes)
                Console.WriteLine(x);
        }

        public static void GetLogs(Drawer drawer)
        {
            Console.WriteLine("Logs:");
            foreach (var x in _shapes)
                drawer.Draw(x);
        }

        public static void AddItem(Shape item)
        {
            _shapes.Add(item);
        }
    }
}