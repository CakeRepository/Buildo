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
        //private const string packages = "7zip adobeair jre8 googlechrome flashplayerplugin adobeshockwaveplayer silverlight";
        private const string packages = "7zip googlechrome";
        public async Task<string> InstallPackages(string installPackages = packages)
        {
            CommandPrompt = new CMD();

            string chocoInstall = await Task.Run(() => checkIfChocoExists());
            
            CommandPrompt = new CMD();

            string pkgInstall = await Task.Run(() => CommandPrompt.RunCMD("choco install " + installPackages + " -y --ignore-checksums"));

            return chocoInstall + " " + pkgInstall;
        }
        private string checkIfChocoExists()
        {
            string path = @"C:\ProgramData\chocolatey";
            if (!Directory.Exists(path))
            {
                var returnVar = install() + ": ";
                CommandPrompt = new CMD();
                return returnVar;

            }
            else
            {
                return "Choco Installed:";
            }
        }
            
    
        private string install()
        {
           return CommandPrompt.RunCMD(@"@powershell -NoProfile -ExecutionPolicy Bypass -Command ""iex ((new-object net.webclient).DownloadString('https://chocolatey.org/install.ps1'))"" && SET PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin");
        }

    }
}
