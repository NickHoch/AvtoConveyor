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
        public override void InstallBody()
        {
            sportCar.Add(new Body());
        }
        public override void InstallEngine()
        {
            sportCar.Add(new Engine());
        }
        public override void InstallAirConditioning()
        {
            sportCar.Add(new AirConditioning());
        }
        public override void InstallSalon()
        {
            sportCar.Add(new Salon());
        }
        public override void InstallRadio()
        {
            sportCar.Add(new Radio());
        }
        public override Car GetResult() /////////////////////////////////////////////////////////////////// answer why can`t I use the class Jeep 
        {
            return sportCar;
        }
    }
}
