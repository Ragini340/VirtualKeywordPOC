using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeywordPOC
{
    class Derived : Base
    {
        public override void Test()
        {
            Console.WriteLine("This is the derived version of the virtual method");
        }

    }
}
