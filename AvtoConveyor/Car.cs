using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConveyor
{
    public abstract class Car
    {
        public ArrayList parts = new ArrayList();
        public abstract void Add(Unit unit);
    }
}
