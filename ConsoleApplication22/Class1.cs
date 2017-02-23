using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    public class A
    {

        protected virtual void v1()
        {
            Console.WriteLine("A::V1");
            s3();
        }

        public void s1()
        {
            Console.WriteLine("A::S1");
            v1();
        }

        private void s3()
        {
            Console.WriteLine("A::S3");

        }

        public void s2()
        {
            Console.WriteLine("A::S2");
            s1();
        }
    }
}