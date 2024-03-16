using Codeizi.Service.Commands;

namespace Codeizi.Service.Executions
{
    [Command(typeof(VersionCommand))]
    public class VersionExecution : IExecution
    {

        public string Proccess()
        {
            return "codeizi      0.0.1";
        }
    }
}
