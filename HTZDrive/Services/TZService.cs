using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTZDrive
{
    public partial class Service
    {
        //TZ Service
        public static TZ GetTZUnit(int Id, string? Jobnumber = null, double UnitID = 0)
        {
            if (!string.IsNullOrEmpty(Jobnumber) && UnitID > 0)
            {
                return new TZ { Id = 0, Jobnumber = Jobnumber, UnitID = UnitID, TZVariable1 = 7, TZVariable2 = 8 };
            }
            else
            {
                return new TZ { Id = Id, Jobnumber = "New Job", UnitID = 1, TZVariable2 = 70, TZVariable1 = 80 };
            }
        }
    }
}
