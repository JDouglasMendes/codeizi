using Codeizi.Service.Commands;
using Codeizi.Service.UI;

namespace Codeizi.Service.Executions
{
    [Command(typeof(VersionCommand))]
    public class VersionExecution(IConsoleManager consoleManager) : IExecutionCommand
    {
        public void Proccess(IEnumerable<ParameterCommand> args)
        {
            consoleManager.Write("codeizi");
            consoleManager.Write("       ");
            consoleManager.Color(ConsoleColor.Green);
            consoleManager.Write("0.0.1 (alfa)");
            consoleManager.Reset();
        }
    }
}
