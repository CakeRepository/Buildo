using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{   
    /// <summary>
    /// Runs command prompt to enable RDP
    /// </summary>
    class EnableRDP
    {

        private CMD CommandPrompt;
        /// <summary>
        /// Sets RDP reg key to allow connections
        /// </summary>
        /// <returns>CMD Results</returns>
        public string Enable()
        {
            CommandPrompt = new CMD();
            return CommandPrompt.RunCMD(@"reg add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server"" /v fDenyTSConnections /t REG_DWORD /d 0 /f");
        }
    }
}
