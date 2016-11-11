using Prism.Commands;
using Prism.Mvvm;

namespace CommandBinderSample
{
    internal class ViewModel : BindableBase
    {
        public DelegateCommand Command1 { get; private set; }
        public DelegateCommand Command2 { get; private set; }


        private string _status;
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }


        private bool _command1Enabled;
        public bool Command1Enabled
        {
            get { return _command1Enabled; }
            set { SetProperty(ref _command1Enabled, value);
                Command1.RaiseCanExecuteChanged();
            }
        }

        private bool _command2Enabled;
        public bool Command2Enabled
        {
            get { return _command2Enabled; }
            set
            {
                SetProperty(ref _command2Enabled, value);
                Command2.RaiseCanExecuteChanged();
            }
        }


        public ViewModel()
        {
            Command1 = new DelegateCommand(Write1, () => Command1Enabled);
            Command2 = new DelegateCommand(Write2, () => Command2Enabled);
        }

        private void Write1()
        {
            Status = "Command1 executed!!!";
        }

        private void Write2()
        {
            Status = "Command2 executed!!!";
        }
    }
}
