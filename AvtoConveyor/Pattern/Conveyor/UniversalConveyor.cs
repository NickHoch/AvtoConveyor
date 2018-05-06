using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoConveyor.Universal;

namespace AutoConveyor.Pattern.Conveyor
{
    public class UniversalConveyor : Conveyor
    {
        Universal.Universal universal = new Universal.Universal();
        public override void InstalledBody()
        {
            universal.Add(new Body());
        }
        public override void InstalledEngine()
        {
            universal.Add(new Engine());
        }
        public override void InstalledAirConditioning()
        {
            universal.Add(new AirConditioning());
        }
        public override void InstalledSalon()
        {
            universal.Add(new Salon());
        }
        public override void InstalledRadio()
        {
            universal.Add(new Radio());
        }
        public override Car GetResult()
        {
            return universal;
        }
    }
}