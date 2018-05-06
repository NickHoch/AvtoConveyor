using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoConveyor.Pattern.Conveyor;
using AutoConveyor.Pattern;

namespace AutoConveyor
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCarConveyor sportCarConveyor = new SportCarConveyor();
            JeepConveyor jeepConveyor = new JeepConveyor();
            UniversalConveyor universal = new UniversalConveyor();
            Engineer engineer = null;
            Car constructedCar = null;
            Console.WriteLine("What type of the car do you want to construct?\n 1 - sport car\n 2 - jeep\n 3 - universal\n");
            bool res = Int32.TryParse(Console.ReadLine(), out int type);
            switch(type)
            {
                case 1:
                    engineer = new Engineer(sportCarConveyor);
                    engineer.Construct();
                    constructedCar = sportCarConveyor.GetResult();
                    break;
                case 2:
                    engineer = new Engineer(jeepConveyor);
                    engineer.Construct();
                    constructedCar = sportCarConveyor.GetResult();
                    break;
                case 3:
                    engineer = new Engineer(universal);
                    engineer.Construct();
                    constructedCar = sportCarConveyor.GetResult();
                    break;
            }
           
            if(constructedCar != null)
            {
                Console.WriteLine("The car has been successfully constructed");
            }
        }
    }
}
