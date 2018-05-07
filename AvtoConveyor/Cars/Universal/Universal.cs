using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoConveyor;

namespace AutoConveyor.Universal
{
    public class Universal : Car
    {
        public override void Add(Unit unit)
        {
            parts.Add(unit);
        }
    }
}
