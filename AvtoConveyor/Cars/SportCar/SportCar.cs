﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoConveyor;

namespace AutoConveyor.SportCar
{
    public class SportCar : Car
    {
        public override void Add(Unit unit)
        {
            parts.Add(unit);
        }
    }
}
