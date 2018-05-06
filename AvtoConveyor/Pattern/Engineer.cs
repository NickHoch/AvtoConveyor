﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoConveyor.Pattern.Conveyor;

namespace AutoConveyor.Pattern
{
    public class Engineer
    {
        private Conveyor.Conveyor conveyor = null;
        public Engineer(Conveyor.Conveyor conveyor)
        {
            this.conveyor = conveyor;
        }
        public void Construct()
        {
            conveyor.InstalledBody();
            conveyor.InstalledEngine();
            conveyor.InstalledAirConditioning();
            conveyor.InstalledSalon();
            conveyor.InstalledRadio();
        }
    }
}
