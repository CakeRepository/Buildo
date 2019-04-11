using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    class PowerSettings
    {
        private CMD CommandPrompt;
        public void setPowerSettings()
        {
            CommandPrompt = new CMD();
            removeHibernate();
            setHardDriveSleep();
            setSleepTime();           
        }

        private void setHardDriveSleep()
        {
            CommandPrompt.RunCMD("powercfg -change disk-timeout-ac 0");
            CommandPrompt.RunCMD("powercfg -change disk-timeout-dc 0");
        }

        private void setSleepTime()
        {
            //Set Monitor Sleep
            CommandPrompt.RunCMD("powercfg -change monitor-timeout-ac 30");
            CommandPrompt.RunCMD("powercfg -change monitor-timeout-dc 30");

            //Set Computer Sleep
            CommandPrompt.RunCMD("powercfg -change standby-timeout-ac 30");
            CommandPrompt.RunCMD("powercfg -change standby-timeout-dc 30");
        }

        private void removeHibernate()
        {
            CommandPrompt.RunCMD("powercfg -h off");
        }
    }
}
