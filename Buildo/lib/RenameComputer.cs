using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Buildo.lib
{
    /// <summary>
    /// Wrapper for computer naming related changes
    /// </summary>
    class RenameComputer
    {
        private CMD CommandPrompt;

        /// <summary>
        /// Sets computer name and runs Powershell through CMD to set it
        /// </summary>
        /// <param name="name">Name of computer</param>
        public void ChangeComputerName(string name = "ChangeMe")
        {
            CommandPrompt = new CMD();
            CommandPrompt.RunCMD(@"@powershell -NoProfile -ExecutionPolicy Bypass -Command rename-computer -NewName " + name);
        }
    }
}
