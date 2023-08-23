using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Exception_Handling
{
    class Exceptions
    {
        

        public int getInt(int[] array1, int index)
        {
            try
            {
                return array1[index];
            }

            catch (IndexOutOfRangeException e) when (index < 0)
            {
                throw new ArgumentOutOfRangeException("Parameter index cannot be negative", e);
            }

            catch (IndexOutOfRangeException e)
            {
                //return 1;
                throw new ArgumentOutOfRangeException("Parameter out of indexr range", e);

            }
            finally
            {
                Console.WriteLine("The elements in the list are: ");
                foreach(int ele in array1)
                {
                    Console.WriteLine(ele);
                }
                
            }
        }
    }
}
