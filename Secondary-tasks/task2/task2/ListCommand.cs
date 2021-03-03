using System;

namespace task2
{
    class ListCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine(Program.userInterface.TeamsManager.ToString());
        }
    }
}