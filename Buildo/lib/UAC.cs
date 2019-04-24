using Buildo.Resources;

namespace Buildo.lib
{
    class UAC
    {
        private CMD CommandPrompt;


        public string removeUAC()
        {
            CommandPrompt = new CMD();
            return CommandPrompt.RunCMD(@"reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f");
            
        }
    }
}
