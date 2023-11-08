using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek8
{//фабрика яка встановлює залежності
    internal class EngineFactory
    {
        public void inject( ICar car, IEngine engine) 
        {
           car.setEngine(engine);
    }
}
}
