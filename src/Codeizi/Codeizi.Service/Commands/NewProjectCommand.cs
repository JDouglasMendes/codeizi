namespace Codeizi.Service.Commands
{
    public record NewProjectCommand : BaseCommand
    {
        public NewProjectCommand() : base("new-project", "np")
        {
        }

        private readonly string[] _parameters = ["-n"];

        public override IEnumerable<ParameterCommand> GetArgs(string[] args)
        {
            var parameters = new List<ParameterCommand>();
            _parameters.ToList().ForEach(p =>
            {
                var index = args.ToList().FindIndex(x => x.Equals(p));
                parameters.Add(new ParameterCommand(p, args[index + 1]));
            });
            return parameters;
        }
    }
}
