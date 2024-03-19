using Codeizi.CLI;
using Codeizi.DI;

public class Program
{
    public static void Main(string[] args)
    {
        new CodeiziManager(new SetupDependencyInjection()).Start(args);
    }
}