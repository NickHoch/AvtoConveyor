using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoConveyor.Jeep;

namespace AutoConveyor.Pattern.Conveyor
{
    public class JeepConveyor : Conveyor
    {
        Jeep.Jeep jeep = new Jeep.Jeep();
        public override void InstallBody()
        {
            jeep.Add(new Body());
        }
        public override void InstallEngine()
        {
            jeep.Add(new Engine());
        }
        public override void InstallAirConditioning()
        {
            jeep.Add(new AirConditioning());
        }
        public override void InstallSalon()
        {
            jeep.Add(new Salon());
        }
        public override void InstallRadio()
        {
            jeep.Add(new Radio());
        }
        public override Car GetResult()
        {
            return jeep;
        }
    }
}
