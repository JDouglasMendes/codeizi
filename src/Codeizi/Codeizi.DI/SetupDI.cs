using Codeizi.Service.Commands;
using Codeizi.Service.Executions;
using Codeizi.Service.UI;
using Microsoft.Extensions.DependencyInjection;

namespace Codeizi.DI
{
    public static class SetupDI
    {
        private static ServiceProvider? _serviceCollection;

        public static void StartSetupApp()
        {
            _serviceCollection = new ServiceCollection()
                .AddScoped<IConsoleManager, ConsoleManager>()
                .AddScoped<VersionExecution>()
                .AddSingleton<FactoryCommand>()
                .BuildServiceProvider();
        }

        public static T Get<T>() where T : notnull
            => _serviceCollection!.GetRequiredService<T>();

    }
}
