namespace task2
{
    abstract class ArgsCommand : Command
    {
        protected internal Arg Arg { get; set; }
        public ArgsCommand(Arg arg)
        {
            Arg = arg;
        }
    }
}