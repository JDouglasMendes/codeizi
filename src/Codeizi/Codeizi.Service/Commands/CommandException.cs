namespace Codeizi.Service.Commands
{
    public class CommandException(string message) : Exception(message)
    {

    }

    public static class CommandNotFound
    {
        public static CommandException Throw(string command) => new($"The {command} not found");
    }

}
