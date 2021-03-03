using System;

namespace task2
{
    [Serializable]
    public class Team
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Team()
        {
            Name = "";
            Score = 0;
        }
        public Team(string name)
        {
            Name = name;
            Score = 0;
        }
        public Team(string name, int score) : this(name)
        {
            if (score < 0)
                throw new ArgumentException("Значение не может быть отрицательным");
            Score = score;
        }
        public void AddScore(int score)
        {
            Score += score;
        }
        public void SubScore(int score)
        {
            if (score > Score)
                throw new ArgumentException("Значение не может быть отрицательным");
            Score -= score;
        }
        public override string ToString()
        {
            return $"{Name} : {Score}";
        }
    }
}