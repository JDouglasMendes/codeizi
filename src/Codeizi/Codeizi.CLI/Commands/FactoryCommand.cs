using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeizi.CLI.Commands
{
    public class FactoryCommand
    {
        public static BaseCommand Create(string token)
        {
            return new VersionCommand();
        }

        public static IEnumerable<BaseCommand> Create(string[] tokens)
        {
            return [new VersionCommand()];
        }
    }
}
