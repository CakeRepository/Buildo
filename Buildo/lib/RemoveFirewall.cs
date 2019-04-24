using Buildo.Resources;
namespace Buildo.lib
{
    class RemoveFirewall
    {
        private CMD CommandPrompt;
        public string AllOff()
        {
            CommandPrompt = new CMD();
            return CommandPrompt.RunCMD("NetSh Advfirewall set allprofiles state off");
        }
    }
}
