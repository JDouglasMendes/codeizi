namespace Codeizi.Service.Commands
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class CommandAttribute : Attribute
    {
        public Type Type { get; }
        public CommandAttribute(Type type)
        {
            this.Type = type;
        }
    }
}
