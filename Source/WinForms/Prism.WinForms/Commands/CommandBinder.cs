using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Prism.Commands
{
    public abstract class CommandBinder<T> : ICommandBinder where T : IComponent
    {
        public Type SourceType
        {
            get { return typeof(T); }
        }

        public void Bind(ICommand command, object source)
        {
            Bind(command, (T)source);
        }

        protected abstract void Bind(ICommand command, T source);
    }
}
