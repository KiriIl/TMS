namespace task2
{
    class LoadFileCommand : FileCommand
    {
        public LoadFileCommand(string fileName) : base(fileName) { }
        public override void Execute()
        {
            Program.userInterface.TeamsManager = TeamsManager.Deserialize(FileName);
        }
    }
}