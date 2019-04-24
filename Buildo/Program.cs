using Buildo.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buildo
{
    static class Program
    {
        //Setup for Redirect to MS Console
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else if(args[0] == "-a")
            {
                AttachConsole(ATTACH_PARENT_PROCESS);
                Console.WriteLine();

                Silent s = new Silent();
                s.runAsync();
            }
            else {
                AttachConsole(ATTACH_PARENT_PROCESS);
                Console.WriteLine(args[0]);
            }
        }
    }
}
