using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeywordPOC
{
    class DriverClass1
    {
        static void Main()
        {
            Base baseObj1 = new Base();
            baseObj1.Test();
            Base baseObj2 = new Derived();
            baseObj2.Test();
        }
    }
}