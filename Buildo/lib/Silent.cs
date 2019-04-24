using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    class Silent
    {
        private void log(string msgLog)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F") + ": " + msgLog);
        }

        public async void runAsync()
        {
            EnableRDP eRDP = new EnableRDP();
            Choco choc = new Choco();
            PowerSettings ps = new PowerSettings();
            RemoveFirewall rf = new RemoveFirewall();
            UAC uacremove = new UAC();

            log("UAC Settings: " + uacremove.removeUAC());
            log("Remove Firewall:" + rf.AllOff());
            string psSettings = await Task.Run(() => ps.setPowerSettings());
            log(psSettings);
            string t = await Task.Run(() => choc.InstallPackages());
            log("Choco: " + t);
            eRDP.Enable();
            log("Enable RDP: " + eRDP.Enable());
        }
    }
}
