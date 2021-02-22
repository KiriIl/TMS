namespace task1
{
    class Safe<T>
    {
        private T template;
        public string Value { get => template.ToString(); }
        public Safe(T value)
        {
            template = value;
        }
    }
}