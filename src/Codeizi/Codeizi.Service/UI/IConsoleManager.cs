namespace Codeizi.Service.UI
{
    public interface IConsoleManager
    {
        void WriteLine(string message);
        void Write(string message);
        void Reset();
        void Color(ConsoleColor color);
    }
}
