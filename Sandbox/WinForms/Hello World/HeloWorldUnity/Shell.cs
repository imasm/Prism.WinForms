using System;
using System.Windows.Forms;
using HelloWorldModule;
using Microsoft.Practices.Unity;

namespace HeloWorldUnity
{
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
            this.Load += Shell_Load;
        }
        
        [Dependency]
        public IHelloService HelloService { get; set; }

        private void Shell_Load(object sender, EventArgs e)
        {
            this.HelloLabel.Text = HelloService.SayHello();
        }
    }
}
