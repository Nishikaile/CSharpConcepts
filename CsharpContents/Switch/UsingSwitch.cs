using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Switch
{
    class UsingSwitch
    {
        public void athmoprts()
        {
            Console.WriteLine("enter value of a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select your choice from 1-5:");
            int c = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case 1:
                    Console.WriteLine("Addition of " + a + " + " + b + " = " + (a + b));
                    break;

                case 2:
                    Console.WriteLine("Subtraction of " + a + " - " + b + " = " + (a - b));
                    break;

                case 3:
                    Console.WriteLine("Multiplication of " + a + " * " + b + " = " + (a * b));
                    break;

                case 4:
                    Console.WriteLine("Division of " + a + " / " + b + " = " + (float)(a + b));
                    break;

                case 5:
                    Console.WriteLine("Modulus of " + a + " % " + b + " = " + (a % b));
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
}
}
