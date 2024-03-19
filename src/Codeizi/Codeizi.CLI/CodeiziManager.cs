using Codeizi.DI;
using Codeizi.Service.Commands;

namespace Codeizi.CLI
{
    public class CodeiziManager : ICodeiziManager
    {
        public void Start(string[] args)
        {
            SetupDI.StartSetupApp();

            var factoryCommands = SetupDI.Get<FactoryCommand>();

            var commands = factoryCommands.Create(args);

            foreach (var command in commands)
            {
                var executionType = factoryCommands.GetExecution(command);
                SetupDI.Get(executionType).Proccess();
            }
        }
    }
}
