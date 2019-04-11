using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    class RenameComputer
    {
        private CMD CommandPrompt;
        public void ChangeComputerName(string name = "ChangeMe")
        {
            CommandPrompt = new CMD();
            CommandPrompt.RunCMD(@"@powershell -NoProfile -ExecutionPolicy Bypass -Command rename-computer -NewName " + name);
        }
    }
}
