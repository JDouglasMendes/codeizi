using Codeizi.Service.Executions;

namespace Codeizi.CLI.Test.Commands
{
    public class VersionExecutionTest
    {
        [Fact]
        public void Proccess_with_success()
        {
            var process = new VersionExecution();

            var result = process.Proccess();

            Assert.Equal("codeizi      0.0.1", result);
        }
    }
}
