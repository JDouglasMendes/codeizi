namespace Codeizi.CLI.Test
{
    public class ProgramSmokeTest
    {
        [Fact]
        public void SmokeOkTest()
        {
            Program.Main(["-version"]);
            Assert.True(true);
        }
    }
}
