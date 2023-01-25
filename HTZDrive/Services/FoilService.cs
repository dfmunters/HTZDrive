using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTZDrive
{
    public partial class Service
    {
        //Foil Service
        public static Foil GetFoilUnit(int Id, string? Jobnumber = null, double UnitID = 0)
        {
            if (!string.IsNullOrEmpty(Jobnumber) && UnitID > 0)
            {
                return new Foil { Id = 0, Jobnumber = Jobnumber, UnitID = UnitID, FoilVariable1 = 7, FoilVariable2 = 8 };
            }
            else
            {
                return new Foil { Id = Id, Jobnumber = "New Job", UnitID = 1, FoilVariable2 = 70, FoilVariable1 = 80 };
            }
        }
    }
}
