using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildo.lib
{
    class UAC
    {
        //Setup Reg Path
        const string SoftwareRootToUAC = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
        const string subkey = "EnableLUA";

        public int removeUAC()
        {
            //Set Reg Key
            Registry.SetValue(SoftwareRootToUAC, subkey, "0" ,RegistryValueKind.DWord);

            //Get Reg Key
            int rInteger = (int)Registry.GetValue(SoftwareRootToUAC, subkey, 1);

            if (rInteger != 1)
            {
                //Success
                return 0;
            }
            else{
                //Fail
                return 1;
            }
        }
    }
}
