using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Replace
{
    class UsingReplace
    {
        public void replace(string s1, string s2, string s3)
        {
            Console.WriteLine("Before replacing" + s1 + "//" + s2 + "//" + s3);
            Console.WriteLine(s1.Replace('#','!'));
            Console.WriteLine(s2.Replace('@','#'));
            Console.WriteLine(s3.Replace('a','A'));


        }
    }
}
