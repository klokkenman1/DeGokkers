using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeGokkers.Forms;
using DeGokkers.Classes;

namespace DeGokkers
{
    static class Program
    {
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            LangResource.RecManager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
