using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace task2
{
    [Serializable]
    public class TeamsManager
    {
        public List<Team> teams { get; set; }
        static XmlSerializer serializer;

        static TeamsManager()
        {
            serializer = new XmlSerializer(typeof(TeamsManager));
        }

        public TeamsManager()
        {
            teams = new List<Team>();
        }

        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        public void AddTeam(string teamName)
        {
            teams.Add(new Team(teamName));
        }

        public void AddTeam(string teamName, int score)
        {
            teams.Add(new Team(teamName, score));
        }

        public void DeleteTeam(string teamName)
        {
            Team selectedTeam = GetTeamByName(teamName);
            teams.Remove(selectedTeam);
        }

        private Team GetTeamByName(string teamName)
        {
            return teams.Where(x => x.Name == teamName).First();
        }

        public void AddScoreToTeam(string teamName, int score)
        {
            Team team = GetTeamByName(teamName);
            team.AddScore(score);
        }

        public void SubScoreToTeam(string teamName, int score)
        {
            Team team = GetTeamByName(teamName);
            team.SubScore(score);
        }

        public void AddTeam(Arg arg)
        {
            AddTeam(arg.TeamName);
        }

        public void DeleteTeam(Arg arg)
        {
            DeleteTeam(arg.TeamName);
        }

        public void AddScoreToTeam(Arg arg)
        {
            AddScoreToTeam(arg.TeamName, arg.Score);
        }

        public void SubScoreToTeam(Arg arg)
        {
            SubScoreToTeam(arg.TeamName, arg.Score);
        }

        public override string ToString()
        {
            StringBuilder resultString = new StringBuilder();
            foreach (var x in teams)
                resultString.AppendLine(x.ToString());
            return resultString.ToString();
        }

        public static void Serialize(TeamsManager manager, string fileName)
        {
            using (FileStream fs = new FileStream($"{fileName}.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, manager);
            }
        }

        public static TeamsManager Deserialize(string fileName)
        {
            TeamsManager manager;
            using (FileStream fs = new FileStream($"{fileName}.xml", FileMode.Open))
            {
                manager = (TeamsManager)serializer.Deserialize(fs);
                Console.WriteLine(manager.ToString());
            }
            return manager;
        }
    }
}