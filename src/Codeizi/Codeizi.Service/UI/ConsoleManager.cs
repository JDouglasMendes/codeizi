namespace Codeizi.Service.UI
{
    public class ConsoleManager : IConsoleManager
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
