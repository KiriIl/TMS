namespace task2
{
    class AddTeamScoreCommand : ScoreCommand
    {
        public AddTeamScoreCommand(Arg arg) : base(arg) { }
        public override void Execute()
        {
            Program.userInterface.TeamsManager.AddScoreToTeam(Arg);
        }
    }
}