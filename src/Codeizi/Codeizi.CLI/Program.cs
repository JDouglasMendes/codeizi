using Codeizi.CLI;
using Codeizi.DI;
using Codeizi.Service.Commands;

public class Program
{
    public static int Main(string[] args)
    {
        try
        {
            new CodeiziManager(new SetupDependencyInjection()).Start(args);
            return 0;
        }
        catch (CommandException)
        {
            return 1;
        }
        catch (Exception)
        {
            return 99;
        }
    }
}