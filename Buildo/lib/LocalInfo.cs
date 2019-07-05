using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.ActiveDirectory;

namespace Buildo.lib
{
    class LocalInfo
    {
        public string getLocalWorkstationDomain()
        {
            try
            {
                Domain domain = Domain.GetComputerDomain();
                return domain.Name;
            }
            catch
            {
                return "Workgroup";
            }
            
        }
        public string getCurrentUser()
        {
           return Environment.UserName;
        }
        public string getMachineName()
        {
            return Environment.MachineName;
        }
    }
}
