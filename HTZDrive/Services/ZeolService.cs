using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTZDrive
{
    public partial class Service
    {
        //Zeol Service

        public static Zeol GetZeolUnit(int Id, string? Jobnumber = null, double UnitID = 0)
        {           
            if (!string.IsNullOrEmpty(Jobnumber) && UnitID > 0)
            {
                return new Zeol { Id = 0, Jobnumber = Jobnumber, UnitID = UnitID, ZeolVariable1 = 1, ZeolVariable2 = 2 };
            }
            else
            {
                return new Zeol { Id = Id, Jobnumber = "New Job", UnitID = 1, ZeolVariable2 = 10, ZeolVariable1 = 20 };
            }
        }

    }
}
