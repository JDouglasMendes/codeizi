namespace Codeizi.Service.Commands
{
    public record VersionCommand : BaseCommand
    {
        public VersionCommand() : base("-version", "-v")
        {
        }
    }
}
