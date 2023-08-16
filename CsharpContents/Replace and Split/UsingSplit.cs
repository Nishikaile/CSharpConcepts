using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Replace_and_Split
{
    class UsingSplit
    {
        public void split()
        {
            String str = "Hello, World!";

            String[] spearator = { "o, ", "World" };
            Int32 count = 2;

            // using the method
            String[] strlist = str.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }
        }
}
}
