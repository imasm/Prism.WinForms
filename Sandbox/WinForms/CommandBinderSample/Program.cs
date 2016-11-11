using System;
using System.Windows.Forms;

namespace CommandBinderSample
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bootstraper b = new Bootstraper();
            b.Run();
        }
    }
}
