using Codeizi.Service.Commands;
using Codeizi.Service.Executions;
using Codeizi.Service.UI;
using Microsoft.Extensions.DependencyInjection;

namespace Codeizi.DI
{
    public class SetupDependencyInjection : ISetupDependencyInjection
    {
        private ServiceProvider? _serviceCollection;

        public void Initialize()
        {
            _serviceCollection = new ServiceCollection()
                .AddScoped<IConsoleManager, ConsoleManager>()
                .AddScoped<VersionExecution>()
                .AddSingleton<FactoryCommand>()
                .BuildServiceProvider();
        }

        public T Get<T>() where T : notnull
            => _serviceCollection!.GetRequiredService<T>();

        public IExecution Get(Type type)
            => (IExecution)_serviceCollection!.GetService(type);

    }
}
