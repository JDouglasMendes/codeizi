using Codeizi.CLI.Executions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeizi.CLI.Commands
{
    public abstract record BaseCommand(string Name,
                                       string ShortName,
                                       IExecution Execution)
    {
        public string Name { get; } = Name;
        public string ShortName { get; } = ShortName;
        public IExecution Execution { get; } = Execution;
    }
}
