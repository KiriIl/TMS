namespace task2
{
    public class Arg
    {
        public string TeamName { get; private set; }
        public int Score { get; private set; }
        public Arg(string teamName, int score)
        {
            TeamName = teamName;
            Score = score;
        }
    }
}