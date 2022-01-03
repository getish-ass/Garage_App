using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class Airplane : Vehicle
    {
        public Airplane(string regnr, string color, int nrofWheels) : base(regnr, color, nrofWheels)
        {
        }

        public int NumberOfEngines { get; set; }  
        public int NumberOfSit { get; set; }   
        public double Length { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Number Of Eng.: {NumberOfEngines} Number Of Sit: {NumberOfSit} Length: {Length}";
        }

    }
}
