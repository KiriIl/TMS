namespace task2
{
    class DeleteTeamCommand : TeamCommand
    {
        public DeleteTeamCommand(Arg arg) : base(arg) { }
        public override void Execute()
        {
            Program.userInterface.TeamsManager.DeleteTeam(Arg);
        }
    }
}