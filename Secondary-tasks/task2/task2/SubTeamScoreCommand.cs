namespace task2
{
    class SubTeamScoreCommand : ScoreCommand
    {
        public SubTeamScoreCommand(Arg arg) : base(arg) { }
        public override void Execute()
        {
            Program.userInterface.TeamsManager.SubScoreToTeam(Arg);
        }
    }
}