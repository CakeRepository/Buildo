using Buildo.Resources;

namespace Buildo.lib
{
    /// <summary>
    /// Wrapper for Powercfg important sleep settings
    /// </summary>
    class PowerSettings
    {
        private CMD CommandPrompt;

        /// <summary>
        /// Runs all functions in this class
        /// </summary>
        /// <returns></returns>
        public string setPowerSettings()
        {
            CommandPrompt = new CMD();
            removeHibernate();
            setHardDriveSleep();
            setSleepTime();
            return "Power Settings Set";
        }

        /// <summary>
        /// Sets hard drive sleep time in powercfg
        /// </summary>
        /// <param name="hDDSleepTimeMin">Requested HDD Sleep Time in min</param>
        private void setHardDriveSleep(string hDDSleepTimeMin = "0")
        {
            //Sets Sleep time of had drive
            CommandPrompt.RunCMD("powercfg -change disk-timeout-ac " + hDDSleepTimeMin);
            CommandPrompt.RunCMD("powercfg -change disk-timeout-dc " + hDDSleepTimeMin);
        }
        /// <summary>
        /// Sets default workstation sleep and monitor sleep time in powercfg
        /// </summary>
        /// <param name="compSleepTimeMin">Sets computer sleep time in Powercfg</param>
        /// <param name="monitorSleepTimeMin">Sets monitor sleep time in Powercfg</param>
        private void setSleepTime(string compSleepTimeMin = "30", string monitorSleepTimeMin = "30")
        {
            //Set Monitor Sleep
            CommandPrompt.RunCMD("powercfg -change monitor-timeout-ac " + monitorSleepTimeMin);
            CommandPrompt.RunCMD("powercfg -change monitor-timeout-dc " + monitorSleepTimeMin);

            //Set Computer Sleep
            CommandPrompt.RunCMD("powercfg -change standby-timeout-ac " + compSleepTimeMin);
            CommandPrompt.RunCMD("powercfg -change standby-timeout-dc " + compSleepTimeMin);
        }
        /// <summary>
        /// Sets hiberate = off
        /// </summary>
        private void removeHibernate()
        {
            CommandPrompt.RunCMD("powercfg -h off");
        }
    }
}
