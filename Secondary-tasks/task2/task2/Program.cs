namespace task2
{
    class Program
    {
        public static UserInterface userInterface;
        public static bool exitRequired = false;

        static void Main(string[] args)
        {
            userInterface = new UserInterface();
            while (!exitRequired)
            {
                userInterface.UserInput();
            }
        }
    }
}