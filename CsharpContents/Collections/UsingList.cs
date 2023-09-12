using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Collections
{
    class UsingList
    {
        public void List()
        {
            var list1 = new List<String>();
            list1.Add("Raghav");
            list1.Add("Janaki");
            list1.Add("1");
            //list1.Remove("1");
            //list1.RemoveAt(1);

          

            var list2 = new List<String> { "Hello", "Hii", "123", "7eyde" };

            for(int i = 0; i < list2.Count();i++)
            {
                Console.WriteLine(list2[i] + " ");
            }

            //foreach(var ele in list1)
            //{
            //    Console.WriteLine(ele);
            //}
            //Console.WriteLine(list1.Count());
            Console.WriteLine(list2.Count());



        }
    }
}
