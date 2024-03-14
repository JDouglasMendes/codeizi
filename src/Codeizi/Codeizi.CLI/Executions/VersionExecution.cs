using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeizi.CLI.Executions
{
    public class VersionExecution : IExecution
    {
        public string Proccess()
        {
            return "codeizi      0.0.1";
        }
    }
}
