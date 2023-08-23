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

            catch(IndexOutOfRangeException e)
            {
                //return 1;
                throw new ArgumentOutOfRangeException("Parameter out of indexr range", e);

            }
        }
    }
}
