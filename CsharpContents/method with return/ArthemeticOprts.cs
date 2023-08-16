using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.method_with_return
{
    class ArthemeticOprts
    {
        public int add(int a,int b)
        {
            return a + b;
        }

         public static int multiply(int a,int b)
        {
            return a * b;
            ArthemeticOprts arthemeticOprts = new ArthemeticOprts();
            Console.WriteLine(multiply(4, 5));
        }

    }
}
