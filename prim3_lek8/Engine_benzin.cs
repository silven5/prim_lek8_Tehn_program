using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek8
{
    internal class Engine_benzin:IEngine
    {
        double currentPower;
        double maxPower;
        string name;
        string name_pal;
        public Engine_benzin()
        {
            this.name = "Бензиновий Двигун";
            this.currentPower = 0;
            this.maxPower = 100;
            this.name_pal = "Бензин";
        }
        public string Name { get { return name; } set { name = value; } }
        public string Name_pal { get { return name_pal; } }
        public double Power
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
