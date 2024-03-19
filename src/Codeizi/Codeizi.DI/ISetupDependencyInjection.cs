using Codeizi.Service.Executions;

namespace Codeizi.DI
{
    public interface ISetupDependencyInjection
    {
        void Initialize();
        T Get<T>() where T : notnull;
        IExecution Get(Type type);
    }
}
