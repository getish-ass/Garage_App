using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class Car : Vehicle
    {
        public double CylVol { get; set; }
        public string? FuelType { get; set; }
        public int NumOfSit { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Cylinder Vol.: {CylVol} Fuel Typ.: {FuelType} Number Of Sit: {NumOfSit}";
        }

    }
}
