using Buildo.Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    class Choco
    {
        private CMD CommandPrompt;
        private const string packages = "7zip adobeair jre8 googlechrome flashplayerplugin adobeshockwaveplayer silverlight";
        
        public async Task InstallPackages(string installPackages = packages)
        {
            CommandPrompt = new CMD();

            await Task.Run(() => checkIfChocoExists());

            await Task.Run(() => CommandPrompt.RunCMD("choco install " + installPackages + " -y --ignore-checksums"));
        }
        private void checkIfChocoExists()
        {
            string path = @"C:\ProgramData\chocolatey";
            if (!Directory.Exists(path))
            {
                install();
                CommandPrompt = new CMD();
            }
        }
            
    
        private void install()
        {
            CommandPrompt.RunCMD(@"@powershell -NoProfile -ExecutionPolicy Bypass -Command ""iex ((new-object net.webclient).DownloadString('https://chocolatey.org/install.ps1'))"" && SET PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin");
        }

    }
}
