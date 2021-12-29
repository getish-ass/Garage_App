﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_App
{
    internal class Boat : Vehicle
    {
        double Length { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Length: {Length}";
        }

    }
}