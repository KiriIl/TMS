namespace task1
{
    abstract class Duck
    {
        public abstract string Quac { get; }
        public override string ToString()
        {
            return Quac.ToString();
        }
    }
}