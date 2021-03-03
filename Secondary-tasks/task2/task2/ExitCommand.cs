namespace task2
{
    class ExitCommand : Command
    {
        public override void Execute()
        {
            Program.exitRequired = true;
        }
    }
}