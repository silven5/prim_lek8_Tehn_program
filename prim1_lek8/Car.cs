using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace prim1_lek8
{
    internal class Car
    {
    public string model ;
    public Engine engine;
   public Car (string model, double power)
        {
            this.model = model;
            this.engine = new Engine();
            this.engine.CurrentPower = power;
        }
    }
}
