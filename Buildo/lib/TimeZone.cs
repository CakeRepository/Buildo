using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    class TimeZone
    {
        private CMD CommandPrompt;
        public string getTimeZone()
        {
            CommandPrompt = new CMD();
            var tz = "";

            tz = CommandPrompt.RunCMD("TZUTIL /g");
            
            return tz;
        }

        public void setTimeZone(string newTimeZone)
        {
            CommandPrompt = new CMD();

            CommandPrompt.RunCMD("TZUTIL /s " + newTimeZone);
            
        }
    }
}   
