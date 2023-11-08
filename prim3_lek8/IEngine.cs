using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek8
{
    internal interface IEngine
    {
        double Power { get; set; }
        string Name { get; set; }
        string Name_pal { get; }
    }
}
