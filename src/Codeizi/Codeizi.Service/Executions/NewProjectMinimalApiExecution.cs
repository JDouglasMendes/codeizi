using Codeizi.Service.Commands;
using Codeizi.Service.UI;
using System.Diagnostics;

namespace Codeizi.Service.Executions
{
    [Command(typeof(NewProjectMinimalApiCommand))]
    public class NewProjectMinimalApiExecution(IConsoleManager console) : IExecutionCommand
    {
        /// <summary>
        /// 1. Enter the name of the project:
        /// --> dotnet new webapiaot -o [name]
        /// </summary>
        public void Proccess(IEnumerable<ParameterCommand> args)
        {
            Process process = new();
            var projectName = string.Empty.ToLower(culture: System.Globalization.CultureInfo.CurrentCulture);
            if (args.Any(x => x.Name == "-n"))
                projectName = args.First(x => x.Name == "-n").Value;

            // Define as propriedades do processo
            process.StartInfo.FileName = "dotnet";
            process.StartInfo.Arguments = $"new webapi -o {projectName}";
            process.StartInfo.UseShellExecute = false; // Necessário para redirecionar a saída
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            // Manipula a saída de dados do processo
            process.OutputDataReceived += (sender, e) => console.WriteLine(e.Data);
            process.ErrorDataReceived += (sender, e) => console.WriteLine(e.Data);

            // Inicia o processo
            process.Start();

            // Começa a ler a saída do processo
            // process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            // Aguarda até que o processo termine
            process.WaitForExit();

            // Verifica o código de saída do processo
            int exitCode = process.ExitCode;
            if (exitCode == 0)
            {
                console.WriteLine("Comando executado com sucesso.");
            }
            else
            {
                console.WriteLine($"Ocorreu um erro ao executar o comando. Código de saída: {exitCode}");
            }
        }
    }
}
