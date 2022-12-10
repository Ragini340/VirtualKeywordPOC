using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeywordPOC
{
    class Base
    {
        public virtual void Test()
        {
            Console.WriteLine("This is the base version of the virtual method");
        }
    }
}
