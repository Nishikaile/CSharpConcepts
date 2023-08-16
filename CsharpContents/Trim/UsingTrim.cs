using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Trim
{
    class UsingTrim
    {
        public void trim(string s1,string s2,string s3)
        {
            Console.WriteLine("Before Trimming" + s1 + "//" + s2 + "//" + s3);
            Console.WriteLine(s1.Trim());
            Console.WriteLine(s2.Trim());
            Console.WriteLine(s3.Trim());


        }
    }
}
