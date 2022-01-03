using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class MotorCycle : Vehicle
    {
        public MotorCycle(string regnr, string color, int nrofWheels, double cylVol) : base(regnr, color, nrofWheels)
        {
            CylVol = cylVol;
        }

        public double CylVol { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Cylinder Vol.: {CylVol}";
        }

    }
}
