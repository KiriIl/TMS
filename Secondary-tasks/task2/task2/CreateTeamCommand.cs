namespace task2
{
    class CreateTeamCommand : TeamCommand
    {
        public CreateTeamCommand(Arg arg) : base(arg) { }
        public override void Execute()
        {
            Program.userInterface.TeamsManager.AddTeam(Arg);
        }
    }
}