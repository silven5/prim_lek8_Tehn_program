using prim1_lek8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim2_lek8
{
    internal class Car: IEngineSetter
    {
        string model;
        Engine engine;
        public Car(string model)
        {
            this.model = model;

        }
        public string Model { get { return model; }  set { model = value; } }
        public void setEngine(Engine engine)
        { this.engine = engine; }
        public Engine Engine
        { get { return engine; } set {  engine = value; } }
    }
}
