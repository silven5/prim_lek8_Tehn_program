using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek8
{
    internal class Car : ICar
    {
        string model;
        IEngine engine;
        public Car(string model)
        {
            this.model = model;

        }
        public string Model { get { return model; } set { model = value; } }
        public void setEngine(IEngine engine)
        { this.engine = engine; }
        public IEngine Engine
        { get { return engine; }  }
    }
}
