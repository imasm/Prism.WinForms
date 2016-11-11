using System.Windows.Forms;
using System.Windows.Input;

namespace Prism.Commands
{
    public class ButtonBinder : CommandBinder<Button>
    {
        protected override void Bind(ICommand command, Button source)
        {
            source.Enabled = command.CanExecute(source);
            command.CanExecuteChanged += (o, e) =>
            {
                source.Enabled = command.CanExecute(o);
            };

            source.Click += (o, e) => command.Execute(o);
        }
    }
}
