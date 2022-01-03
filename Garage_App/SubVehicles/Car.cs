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

        public Car(string regnr, string color, int nrofWheels, double cylinderVol) : base(regnr, color, nrofWheels)
        {
            CylVol = cylinderVol;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Cylinder Vol.: {CylVol}.";
        }

    }
}
