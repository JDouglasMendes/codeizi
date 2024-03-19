using Codeizi.DI;
using Codeizi.Service.Commands;

public class Program
{
    static void Main(string[] args)
    {
#if DEBUG
        args = ["-version"];
#endif
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