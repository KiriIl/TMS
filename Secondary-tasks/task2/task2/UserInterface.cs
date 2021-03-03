using System;
using System.IO;

namespace task2
{
    class UserInterface
    {
        public TeamsManager TeamsManager { get; set; }
        public UserInterface()
        {
            TeamsManager = new TeamsManager();
        }
        public void UserInput()
        {
            try
            {
                string userInput = ReadInput();
                Command outCommand = Parser.ParseCommand(userInput);
                outCommand.Execute();
            }
            catch (FileNotFoundException e) { Console.WriteLine($"Файл не найден {e.FileName}"); }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            catch (InvalidOperationException e) { Console.WriteLine(e.Message); }
            catch (InvalidCommandException e) { Console.WriteLine(e.Message); }
        }

        private string ReadInput()
        {
            Console.WriteLine("Введите команду");
            return Console.ReadLine();
        }
    }
}