using Codeizi.CLI.Commands;

public class Program
{
    static void Main(string[] args)
    {
        var commands = FactoryCommand.Create(args);
        foreach (var command in commands)
        {
            Console.WriteLine(command.Execution.Proccess());
        }

    }
}