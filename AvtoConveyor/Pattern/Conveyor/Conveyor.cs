using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoConveyor;

namespace AutoConveyor.Pattern.Conveyor
{
    public abstract class Conveyor
    {
        public abstract void InstalledBody();
        public abstract void InstalledEngine();
        public abstract void InstalledAirConditioning();
        public abstract void InstalledSalon();
        public abstract void InstalledRadio();
        public abstract Car GetResult();
    }
}
