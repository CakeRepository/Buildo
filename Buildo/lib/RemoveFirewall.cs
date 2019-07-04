using Buildo.Resources;
namespace Buildo.lib
{
    /// <summary>
    /// Wrapper for Firewall Related removal 
    /// </summary>
    class RemoveFirewall
    {
        private CMD CommandPrompt;
        /// <summary>
        /// Runs CMD to disable firewall for all profiles
        /// </summary>
        /// <returns>CMD Results</returns>
        public string AllOff()
        {
            CommandPrompt = new CMD();
            return CommandPrompt.RunCMD("NetSh Advfirewall set allprofiles state off");
        }
    }
}
