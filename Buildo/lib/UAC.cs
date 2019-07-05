using Buildo.Resources;

namespace Buildo.lib
{
    /// <summary>
    /// Wrapper for UAC Related changes probably only one :) 
    /// </summary>
    class UAC
    {
        private CMD CommandPrompt;

        /// <summary>
        /// Disable UAC through Command Prompt
        /// </summary>
        /// <returns>CMD Results</returns>
        public string removeUAC()
        {
            CommandPrompt = new CMD();
            return CommandPrompt.RunCMD(@"reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f");
            
        }
    }
}
