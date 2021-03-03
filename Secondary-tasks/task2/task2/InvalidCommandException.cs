using System;

namespace task2
{
    class InvalidCommandException : Exception
    {
        public string Command { get; private set; }
        public override string Message { get => $"Неверное имя команды {Command}"; }
        public InvalidCommandException(string command)
        {
            Command = command;
        }
    }
}
