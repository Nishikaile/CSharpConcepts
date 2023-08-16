using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Loops
{
    class While
    {
        public void method2()
        {
            int range = Convert.ToInt32(Console.ReadLine());

            int i=1;

            while(i < range)//infinite while loop if i is not incremented.

            {
                for (i = 1; i < range; i++) { Console.WriteLine("hello"); } 
               

            }
        }
    }
}
