using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoConveyor.SportCar;

namespace AutoConveyor.Pattern.Conveyor
{
    public class SportCarConveyor : Conveyor
    {
        SportCar.SportCar sportCar = new SportCar.SportCar();
        public override void InstalledBody()
        {
            sportCar.Add(new Body());
        }
        public override void InstalledEngine()
        {
            sportCar.Add(new Engine());
        }
        public override void InstalledAirConditioning()
        {
            sportCar.Add(new AirConditioning());
        }
        public override void InstalledSalon()
        {
            sportCar.Add(new Salon());
        }
        public override void InstalledRadio()
        {
            sportCar.Add(new Radio());
        }
        public override Car GetResult() /////////////////////////////////////////////////////////////////// answer why can`t I use the class Jeep 
        {
            return sportCar;
        }
    }
}
