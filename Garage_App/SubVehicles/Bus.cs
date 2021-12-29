using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class Bus : Vehicle
    {

        public double CylVol { get; set; }
        public string FuelType { get; set; }
        public int NumOfSit { get; set; }
        public double Length { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Cylinder Vol.: {CylVol}, Fuel: {FuelType}, Number Of Sit: {NumOfSit}, Length: {Length}";
        }
    }
}
