using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    class WindowsUpdate
    {
        private CMD CommandPrompt;
        public void OpenWindowsUpdate()
        {
            CommandPrompt = new CMD();

            CommandPrompt.RunCMD("start explorer ms-settings:windowsupdate");
        }
    }
}
