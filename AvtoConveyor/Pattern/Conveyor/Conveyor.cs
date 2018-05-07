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
        public abstract void InstallBody();
        public abstract void InstallEngine();
        public abstract void InstallAirConditioning();
        public abstract void InstallSalon();
        public abstract void InstallRadio();
        public abstract Car GetResult();
    }
}