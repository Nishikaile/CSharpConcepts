using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Loops
{
    class ForEach
    {
        public void method3()
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
