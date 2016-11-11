using System;
using System.Windows.Input;

namespace Prism.Commands
{
    public interface ICommandBinder
    {
        Type SourceType { get; }
        void Bind(ICommand command, object source);
    }
}
