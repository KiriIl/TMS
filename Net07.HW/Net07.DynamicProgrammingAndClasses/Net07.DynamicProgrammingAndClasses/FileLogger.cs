using System.IO;

namespace Net07.DynamicProgrammingAndClasses
{
    class FileLogger : Logger
    {
        public override void Log(Shape shape)
        {
            File.AppendAllText("Logger.txt", PrintShape(shape));
        }
    }
}
