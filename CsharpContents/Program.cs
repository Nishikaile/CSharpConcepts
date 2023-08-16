using CsharpContents.Access_specifiers;
using CsharpContents.methods_without_return;
using CsharpContents.method_with_return;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpContents.Trim;

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

            var obj3 = new WithoutReturn();
            obj3.fun4(3);

            ArthemeticOprts obj4 = new ArthemeticOprts();
            Console.WriteLine("Multiplication: "+ArthemeticOprts.multiply(4,5));

            int c=obj4.add(2, 3);
            Console.WriteLine("Result of add fun:"+c);


            UsingTrim obj5 = new UsingTrim();
            obj5.trim("     Raghav","Raghav      ","Raghav");
            Console.ReadKey();
        }
    }
}
