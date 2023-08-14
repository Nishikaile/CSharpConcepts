using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Access_specifiers
{
    class Class1
    {
        public void getData()
        {
            Console.WriteLine("this is public method");
            Console.ReadKey();

        }

        private void fun1()
        {
            Console.WriteLine("This is private");
            Console.ReadKey();
        }

        protected void fun2()
        {
            Console.WriteLine("This is protected");
            Console.ReadKey();
        }

        public static void SomeData()
        {
            Console.WriteLine("This is static method");
            Console.ReadKey();
        }
    }

    class Class2:Class1
    {
        public void fun3()
        {
            Console.WriteLine("This is child class of class2");
            Class2 obj3 = new Class2();
            obj3.fun2();

        }


        public void evenodd(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

        }

        public void evennumbers(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even numbers:" + i);
                }
                else
                {
                    Console.WriteLine("Odd numbers" + i);
                }
            }
        }


    }

}
