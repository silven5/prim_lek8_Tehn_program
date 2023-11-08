using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim1_lek8
{
    internal class Car_set
    {
        public string model;
        Engine engine;
        public Car_set(string model)
        {
            this.model = model;

        }
        public Engine Engine { get { return engine; } 
        set { engine = value; }
        }
    }
}

