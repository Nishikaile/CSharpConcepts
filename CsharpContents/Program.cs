using CsharpContents.Access_specifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Class1();
            obj.getData();

            Class2 obj2 = new Class2();
            obj2.fun3();
            Class1.SomeData();
            obj2.evenodd(10);
            obj2.evennumbers(10);

        }
    }
}
