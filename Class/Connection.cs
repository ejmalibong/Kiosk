using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using BlackCoffeeLibrary;
using Kiosk.Class;

namespace Kiosk.Class
{
    public class Connection
    {
        public string GetConnectionString()
        {
            if (Properties.Settings.Default.isDebug)
            {
                return "Data Source=NBCP-LT-144\\SQLEXPRESS;Initial Catalog=LeaveFiling;Persist Security Info=False;User ID=sa;Password=Nbc12#";
            }
            else
            {
                return "Data Source=192.168.20.230;Initial Catalog=MachineMonitoring;Persist Security Info=False;User ID=sa;Password=Nbc12#";
            }
        }
    }
}
