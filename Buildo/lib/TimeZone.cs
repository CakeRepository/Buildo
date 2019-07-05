using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    /// <summary>
    /// Wrapper for timezome related changes
    /// </summary>
    class TimeZone
    {
        private CMD CommandPrompt;

        /// <summary>
        /// Gets current Time Zone of workstation to display in GUI
        /// </summary>
        /// <returns>Current Timezone</returns>
        public string getTimeZone()
        {
            CommandPrompt = new CMD();
            var tz = "";

            tz = CommandPrompt.RunCMD("TZUTIL /g");
            
            return tz;
        }

        /// <summary>
        /// Sets timezone with TZUTIL through CMD
        /// </summary>
        /// <param name="newTimeZone">Requeted timezone this must match Microsofts timezone naming convention</param>
        public void setTimeZone(string newTimeZone)
        {
            CommandPrompt = new CMD();

            CommandPrompt.RunCMD("TZUTIL /s " + newTimeZone);
            
        }
    }
}   
