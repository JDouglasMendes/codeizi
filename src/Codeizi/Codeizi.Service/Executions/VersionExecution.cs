using Codeizi.Service.Commands;
using Codeizi.Service.UI;

namespace Codeizi.Service.Executions
{
    [Command(typeof(VersionCommand))]
    public class VersionExecution : IExecution
    {
        private readonly IConsoleManager consoleManager;

        public VersionExecution(IConsoleManager consoleManager)
        {
            this.consoleManager = consoleManager;
        }

        public void Proccess()
        {
            consoleManager.WriteLine("codeizi      0.0.1");
        }
    }
}
