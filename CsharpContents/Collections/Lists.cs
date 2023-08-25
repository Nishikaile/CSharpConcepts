using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpContents.Collections
{
    public class Lists
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public void IterateThroughLists()
        {
            var theList = new List<Lists>
                {
                    new Lists() { Name="Nishi",Id=1},
                    new Lists() { Name="Latha",Id=2},
                    new Lists() { Name="kaile",Id=3}

                };

            foreach (Lists lst in theList)
            {
                Console.WriteLine(lst.Name + " " + lst.Id);
            }
        }
    }
}
