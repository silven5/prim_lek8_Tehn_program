using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek8
{
    internal class Moto:ICar
    {
        string model;
        string type;
        IEngine engine;
        public Moto(string model, string type)
        {
            this.model = model;
            this.type = type;
        }
        public string Model { get { return model; } set { model = value; } }
        public string Type { get { return type; } set { type = value; } }
        public void setEngine(IEngine engine)
        { this.engine = engine; }
        public IEngine Engine
        { get { return engine; } }
    }
}
