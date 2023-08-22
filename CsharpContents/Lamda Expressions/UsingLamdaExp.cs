using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Lamda_Expressions
{
    class UsingLamdaExp
    {
        public void lamdaexp()
        {
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                    
                    numbers.RemoveAt(index);
                }
            }
            numbers.ForEach(number => Console.Write(number + " "));
        }
    }
}
