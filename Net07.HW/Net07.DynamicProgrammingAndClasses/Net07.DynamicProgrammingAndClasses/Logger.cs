namespace Net07.DynamicProgrammingAndClasses
{
    abstract class Logger
    {
        public abstract void Log(Shape shape);
        protected string PrintShape(Shape shape)
        {
            return $"{shape}";
        }
    }
}