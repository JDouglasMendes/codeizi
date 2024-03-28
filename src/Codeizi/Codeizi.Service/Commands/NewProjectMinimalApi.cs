namespace Codeizi.Service.Commands
{
    public record NewProjectMinimalApi : BaseCommand
    {
        public NewProjectMinimalApi() : base("np-minimal-api", "npmapi") { }

        private readonly string[] _parameters = ["-n", "-name"];

        public override IEnumerable<ParameterCommand> GetArgs(string[] args)
        {
            var parameters = new List<ParameterCommand>();
            _parameters.ToList().ForEach(p =>
            {
                var index = args.ToList().FindIndex(x => x.Equals(p));
                if (parameters.Count != 0 && index >= 0)
                    throw DuplicatedParameter.Throw(p);

                if (index >= 0)
                    parameters.Add(new ParameterCommand(p, args[index + 1]));
            });
            return parameters;
        }
    }
}
