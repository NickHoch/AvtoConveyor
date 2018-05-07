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
        public override void InstallBody()
        {
            universal.Add(new Body());
        }
        public override void InstallEngine()
        {
            universal.Add(new Engine());
        }
        public override void InstallAirConditioning()
        {
            universal.Add(new AirConditioning());
        }
        public override void InstallSalon()
        {
            universal.Add(new Salon());
        }
        public override void InstallRadio()
        {
            universal.Add(new Radio());
        }
        public override Car GetResult()
        {
            return universal;
        }
    }
}