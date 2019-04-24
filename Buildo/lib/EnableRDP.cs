using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    class EnableRDP
    {

        private CMD CommandPrompt;

        public string Enable()
        {
            CommandPrompt = new CMD();
            return CommandPrompt.RunCMD(@"reg add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server"" /v fDenyTSConnections /t REG_DWORD /d 0 /f");
        }
    }
}
