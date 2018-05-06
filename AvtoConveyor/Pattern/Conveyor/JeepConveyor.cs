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
        public override void InstalledBody()
        {
            jeep.Add(new Body());
        }
        public override void InstalledEngine()
        {
            jeep.Add(new Engine());
        }
        public override void InstalledAirConditioning()
        {
            jeep.Add(new AirConditioning());
        }
        public override void InstalledSalon()
        {
            jeep.Add(new Salon());
        }
        public override void InstalledRadio()
        {
            jeep.Add(new Radio());
        }
        public override Car GetResult()
        {
            return jeep;
        }
    }
}
