using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    public class C : B
    {
        public void s6()
        {
            Console.WriteLine("C::S6");
            v1();
        }

        public void s7()
        {
            Console.WriteLine("C::S7");
            v2();
        }
    }
}