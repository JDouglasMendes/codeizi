using Codeizi.Service.Commands;
using Codeizi.Service.UI;

namespace Codeizi.Service.Executions
{
    [Command(typeof(VersionCommand))]
    public class VersionExecution : IExecutionCommand
    {
        private readonly IConsoleManager consoleManager;

        public VersionExecution(IConsoleManager consoleManager)
        {
            this.consoleManager = consoleManager;
        }

        public void Proccess()
        {
            consoleManager.Write("codeizi");
            consoleManager.Write("       ");
            consoleManager.Color(ConsoleColor.Green);
            consoleManager.Write("0.0.1 (alfa)");
            consoleManager.Reset();
        }
    }
}
