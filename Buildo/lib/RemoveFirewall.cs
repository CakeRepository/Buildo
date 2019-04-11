using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    class RemoveFirewall
    {
        private CMD CommandPrompt;
        public void AllOff()
        {
            CommandPrompt = new CMD();
            CommandPrompt.RunCMD("NetSh Advfirewall set allprofiles state off");
        }
    }
}
