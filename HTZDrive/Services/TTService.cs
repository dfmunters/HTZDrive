using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTZDrive
{
    public partial class Service
    {
        //TT Service

        public static TT GetTTUnit(int Id, string? Jobnumber = null, double UnitID = 0)
        {
            if (!string.IsNullOrEmpty(Jobnumber) && UnitID > 0)
            {
                return new TT { Id = 0, Jobnumber = Jobnumber, UnitID = UnitID, TTVariable1 = 3, TTVariable2 = 4 };
            }
            else
            {
                return new TT { Id = Id, Jobnumber = "New Job", UnitID = 1, TTVariable2 = 30, TTVariable1 = 40 };
            }
        }

    }
}
