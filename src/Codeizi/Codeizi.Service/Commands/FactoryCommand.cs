namespace Codeizi.Service.Commands
{
    public class FactoryCommand
    {
        public BaseCommand Create(string token)
        {
            return new VersionCommand();
        }

        public IEnumerable<BaseCommand> Create(string[] tokens)
        {
            return [new VersionCommand()];
        }
    }
}
