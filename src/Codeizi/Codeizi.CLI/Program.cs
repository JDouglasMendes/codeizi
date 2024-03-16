using Codeizi.DI;
using Codeizi.Service.Commands;

public class Program
{
    static void Main(string[] args)
    {
        SetupDI.StartSetupApp();

        var factoryCommands = SetupDI.Get<FactoryCommand>();

        var commands = factoryCommands.Create(args);

    }
}