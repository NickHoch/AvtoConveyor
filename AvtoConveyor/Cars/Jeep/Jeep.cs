using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConveyor.Jeep
{
    public class Jeep : Car
    {
        public override void Add(Unit unit)
        {
            parts.Add(unit);
        }
    }
}
