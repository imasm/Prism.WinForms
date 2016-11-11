using Prism.Commands;
using System.Windows.Forms;

namespace CommandBinderSample
{
    public partial class View : UserControl
    {
        CommandManager commandManager = new CommandManager();
        ViewModel viewModel;

        public View()
        {
            InitializeComponent();

            viewModel = new ViewModel();

            statusLabel.DataBindings.Add("Text", viewModel, "Status");

            commandManager.Bind(viewModel.Command1, toolStrip1);
            commandManager.Bind(viewModel.Command2, toolStrip2);

            commandManager.Bind(viewModel.Command1, button1);
            commandManager.Bind(viewModel.Command2, button2);

            checkBox1.CheckedChanged += (o, e) => viewModel.Command1Enabled = checkBox1.Checked;
            checkBox2.CheckedChanged += (o, e) => viewModel.Command2Enabled = checkBox2.Checked;
        }
    }
}
