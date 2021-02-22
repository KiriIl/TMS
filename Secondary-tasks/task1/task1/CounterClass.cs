namespace task1
{
    class CounterClass
    {
        public static int Counter { get; private set; }
        public int NonStaticCounter { get => Counter; }
        static CounterClass()
        {
            Counter = 0;
        }
        public CounterClass()
        {
            Counter++;
        }
    }
}