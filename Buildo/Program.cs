using Buildo.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDesk.Options;

namespace Buildo
{
    static class Program
    {
        //Setup for Redirect to MS Console
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;
        /// <summary>
        /// The main entry point for the application. Allowing args and parsing with ndesk
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
            else
            {
                AttachConsole(ATTACH_PARENT_PROCESS);
                bool show_help = false;
                bool automate = false;
                string filepath = null;
                int repeat = 1;

                var p = new OptionSet() {
            { "f|filepath=", "the {Full Config File Path} of your configuration file.",
              v => filepath = v },
            { "s|server=",
                "this runs {SERVER} customization automation.",
              (int v) => repeat = v },
            { "h|help",  "show this message and exit",
              v => show_help = v != null },
            { "a|automate",  "Install Choco ansd set default settings",
              v => automate = v != null },
        };

                List<string> extra;
                try
                {
                    extra = p.Parse(args);
                }
                catch (OptionException e)
                {
                    Console.WriteLine("Try `greet --help' for more information.");
                    return;
                }
                if (automate)
                {
                    if (filepath == null)
                    {
                        Silent s = new Silent();
                        s.RunSilent();

                        return;
                    }


                }
                if (show_help)
                {
                    ShowHelp(p);
                    return;
                }
            }            
        }
         static void ShowHelp(OptionSet p)
        {
            Console.WriteLine("Welcome to Buildo");
            Console.WriteLine("If you run into any issues please update the git repo located.");
            Console.WriteLine("https://github.com/CakeRepository/Buildo/tree/master/Buildo");
            Console.WriteLine("This is completely open source and feel free to make pull/merge requests. Cake");
            Console.WriteLine();
            Console.WriteLine("Options:");
            p.WriteOptionDescriptions(Console.Out);
        }
    }
}
