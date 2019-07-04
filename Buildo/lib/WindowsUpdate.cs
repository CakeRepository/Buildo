using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{

    /// <summary>
    /// Wrapper for windows updates through C# its pretty bad currently
    /// </summary>
    class WindowsUpdate
    {
        private CMD CommandPrompt;

        /// <summary>
        /// Really stupid only opens CMD Will implimet powershell at somepoint to automate
        /// </summary>
        public void OpenWindowsUpdate()
        {
            CommandPrompt = new CMD();

            CommandPrompt.RunCMD("start explorer ms-settings:windowsupdate");
        }
    }
}
