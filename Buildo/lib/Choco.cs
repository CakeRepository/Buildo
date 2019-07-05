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

        /// <summary>
        /// Installs Choco packages Async
        /// </summary>
        /// <param name="installPackages"></param>
        /// <returns>Results from CMD for Packages and Choco application</returns>
        public async Task<string> InstallPackages(string installPackages = packages)
        {
            CommandPrompt = new CMD();

            string chocoInstall = await Task.Run(() => checkIfChocoExists());

            string pkgInstall = await Task.Run(() => CommandPrompt.RunCMD("choco install " + installPackages + " -y --ignore-checksums"));
            
            return chocoInstall + " " + pkgInstall;
        }


        /// <summary>
        /// Check if choco exists runs install function if it doesnt
        /// </summary>
        /// <returns>CMD from running choco install or text saying it was installed</returns>
        private string checkIfChocoExists()
        {
            string path = @"C:\ProgramData\chocolatey";
            if (!Directory.Exists(path))
            {
                var returnVar = install() + ": ";
                return returnVar;

            }
            else
            {
                return "Choco Installed:";
            }
        }
            
        /// <summary>
        /// Installs Choco
        /// </summary>
        /// <returns>Results from CMD</returns>
        private string install()
        {
           return CommandPrompt.RunCMD(@"@powershell -NoProfile -ExecutionPolicy Bypass -Command ""iex ((new-object net.webclient).DownloadString('https://chocolatey.org/install.ps1'))"" && SET PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin");
        }

        /// <summary>
        /// Used for Silent running currently doesnt support packages being installed at the same time
        /// </summary>
        /// <param name="installPackages"></param>
        /// <returns>CMD results from Choco Installation or lack there of</returns>
        public string silentRun(string installPackages = packages)
        {
            CommandPrompt = new CMD();
            string chocoInstall = checkIfChocoExists();

            //Not working because closing cmd causes issues with the way the program reacts
            //CommandPrompt = new CMD();
            //string pkgInstall = CommandPrompt.RunCMD("choco install " + installPackages + " -y --ignore-checksums");

            return chocoInstall;
        }
    }
}
