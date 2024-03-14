using Codeizi.CLI.Executions;

namespace Codeizi.CLI.Commands
{
    public record VersionCommand : BaseCommand
    {
        public VersionCommand() : base("version", "v", new VersionExecution())
        {
        }
    }
}
