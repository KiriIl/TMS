using System;
using System.Text.RegularExpressions;

namespace task2
{
    static class Parser
    {
        const string _parseCommandPattern = @"^(?<command>\w+)\s*(?<args>.*)";
        const string _parseArgsPattern = @"^(?<team>\w+)\s*(?<score>\d*)";
        static Regex _parseCommandRegex = new Regex(_parseCommandPattern);
        static Regex _parseArgsRegex = new Regex(_parseArgsPattern);

        public static Command ParseCommand(string userInpur)
        {
            string commandName = "", args = "";
            var match = _parseCommandRegex.Match(userInpur);
            if (match.Success)
            {
                commandName = match.Groups["command"].Value;
                args = match.Groups["args"].Value;
            }
            return SelectCommand(commandName, args);
        }

        private static Command SelectCommand(string commandName, string args)
        {
            switch (commandName.ToLower())
            {
                case "create": return CreateInstantiateTeamCommand(args);
                case "delete": return CreateDeleteTeamCommand(args);
                case "add": return CreateAddScoreCommand(args);
                case "sub": return CreateSubScoreCommand(args);
                case "load": return CreateLoadFromFileCommand(args);
                case "save": return CreateSaveInFileCommand(args);
                case "list": return CreateListCommand();
                case "exit": return CreateExitCommand();
                default: throw new InvalidCommandException(commandName);
            }
        }

        private static Arg ParseToArgs(string stringArgs)
        {
            Match match = _parseArgsRegex.Match(stringArgs);
            string teamName = match.Groups["team"].Value;
            if (!int.TryParse(match.Groups["score"].Value, out int score))
                score = 0;
            return new Arg(teamName, score);
        }

        private static ListCommand CreateListCommand()
        {
            return new ListCommand();
        }

        private static ExitCommand CreateExitCommand()
        {
            return new ExitCommand();
        }

        private static SaveFileCommand CreateSaveInFileCommand(string fileName)
        {
            return new SaveFileCommand(fileName);
        }

        private static LoadFileCommand CreateLoadFromFileCommand(string fileName)
        {
            return new LoadFileCommand(fileName);
        }

        private static CreateTeamCommand CreateInstantiateTeamCommand(string stringArgs)
        {
            Arg arg = ParseToArgs(stringArgs);
            return new CreateTeamCommand(arg);
        }

        private static DeleteTeamCommand CreateDeleteTeamCommand(string stringArgs)
        {
            Arg arg = ParseToArgs(stringArgs);
            return new DeleteTeamCommand(arg);
        }

        private static AddTeamScoreCommand CreateAddScoreCommand(string stringArgs)
        {
            Arg arg = ParseToArgs(stringArgs);
            return new AddTeamScoreCommand(arg);
        }

        private static SubTeamScoreCommand CreateSubScoreCommand(string stringArgs)
        {
            Arg arg = ParseToArgs(stringArgs);
            return new SubTeamScoreCommand(arg);
        }
    }
}