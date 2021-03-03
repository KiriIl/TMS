namespace task2
{
    abstract class FileCommand : Command
    {
        protected internal string FileName { get; protected set; }
        public FileCommand(string fileName)
        {
            FileName = fileName;
        }
    }
}