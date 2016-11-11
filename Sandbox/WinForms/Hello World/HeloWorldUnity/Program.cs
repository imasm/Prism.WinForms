using System;
using System.Windows.Forms;

namespace HeloWorldUnity
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
