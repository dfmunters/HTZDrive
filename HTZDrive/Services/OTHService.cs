using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTZDrive
{
    public partial class Service
    {
        //OTH Service
        public static OTH GetOTHUnit(int Id, string? Jobnumber = null, double UnitID = 0)
        {
            if (!string.IsNullOrEmpty(Jobnumber) && UnitID > 0)
            {
                return new OTH { Id = 0, Jobnumber = Jobnumber, UnitID = UnitID, OTHVariable1 = 5, OTHVariable2 = 6 };
            }
            else
            {
                return new OTH { Id = Id, Jobnumber = "New Job", UnitID = 1, OTHVariable2 =50, OTHVariable1 = 60 };
            }
        }
    }
}
