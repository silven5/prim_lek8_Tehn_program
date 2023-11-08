using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim1_lek8
{
    internal class Car_DI_constructor
    {
        public string model;
        public Engine engine;
        public Car_DI_constructor(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }
    }
}

