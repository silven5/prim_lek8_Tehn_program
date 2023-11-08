using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prim1_lek8
{
    public class Engine
    {
        double currentPower;
        double maxPower;
   public Engine()
        {
            this.currentPower = 0;
            this.maxPower = 100;
        }
        public double CurrentPower
        {
            get { return this.currentPower; }
            set
            {
                if (value >= 0 && value < this.maxPower)
                {
                    this.currentPower = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Incorrect power value");

                }
            }
        }
        }
}
