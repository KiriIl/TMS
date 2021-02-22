using System;

namespace Net07.DynamicProgrammingAndClasses
{
    class ConsoleLogger : Logger
    {
        public override void Log(Shape shape)
        {
            Console.WriteLine(PrintShape(shape));
        }
    }
}
