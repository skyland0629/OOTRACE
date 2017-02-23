using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    public class B : A
    {
        protected void s4()
        {
            Console.WriteLine("B::S4");
            v1();
        }

        public void s5()
        {
            Console.WriteLine("B::S5");
            s3();
        }

        protected void s3()
        {
            Console.WriteLine("B::S3");
        }

        protected virtual void v1()
        {
            Console.WriteLine("B::v1");
            s5();
        }

        public virtual void v2()
        {
            Console.WriteLine("B::v2");
            v1();
        }
    }
}