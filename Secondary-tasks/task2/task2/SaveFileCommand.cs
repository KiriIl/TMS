namespace task2
{
    class SaveFileCommand : FileCommand
    {
        public SaveFileCommand(string fileName) : base(fileName) { }
        public override void Execute()
        {
            TeamsManager.Serialize(Program.userInterface.TeamsManager, FileName);
        }
    }
}