using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek8
{
    internal class Engine_elektro:IEngine
    {
        double currentPower;
        string name;
        string name_pal;
        public Engine_elektro()
        {
            this.name = "Електричний двигун";
            this.currentPower = 0;
            this.name_pal = "ток";
        }
        public string Name { get { return name; } set { name = value; } }
        public string Name_pal { get { return name_pal; } }
        public double Power
        {
            get { return this.currentPower; }
            set
            {
                if (value >= 0 )
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

