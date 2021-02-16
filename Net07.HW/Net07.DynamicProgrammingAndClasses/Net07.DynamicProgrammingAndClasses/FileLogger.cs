using System.IO;

namespace Net07.DynamicProgrammingAndClasses
{
    class FileLogger : Logger
    {
        public override void Log(Shape shape)
        {
            File.WriteAllText("Logger.txt", PrintShape(shape));
        }
    }
}
