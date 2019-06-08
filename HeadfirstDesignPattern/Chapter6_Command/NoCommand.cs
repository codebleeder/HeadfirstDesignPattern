namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class NoCommand: Command
    {
        public NoCommand()
        {
        }

        public void Execute()
        {
            System.Console.WriteLine("No Command");
        }

        public void Undo()
        {
            
        }
    }
}