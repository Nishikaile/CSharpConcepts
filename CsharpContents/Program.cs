using CsharpContents.Access_specifiers;
using CsharpContents.methods_without_return;
using CsharpContents.method_with_return;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpContents.Trim;
using CsharpContents.Switch;
using CsharpContents.Loops;
using CsharpContents.Replace;
using CsharpContents.Replace_and_Split;
using CsharpContents.Collections;
using CsharpContents.Exception_Handling;
using CsharpContents.Collections.Dictionaries;

namespace CsharpContents
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ////var obj = new Class1();
            ////obj.getData();

            ////Class2 obj2 = new Class2();
            ////obj2.fun3();
            ////Class1.SomeData();
            ////obj2.evenodd(10);
            ////obj2.evennumbers(10);

            ////var obj3 = new WithoutReturn();
            ////obj3.fun4(3);

            ////ArthemeticOprts obj4 = new ArthemeticOprts();
            ////Console.WriteLine("Multiplication: "+ArthemeticOprts.multiply(4,5));

            ////int c=obj4.add(2, 3);
            ////Console.WriteLine("Result of add fun:"+c);


            ////UsingTrim obj5 = new UsingTrim();
            ////obj5.trim("     Raghav","Raghav      ","Raghav");

            //UsingSwitch obj6 = new UsingSwitch();
            //obj6.athmoprts();

            //UsingIf obj7 = new UsingIf();
            //obj7.method1(3);

            //For obj8 = new For();
            //obj8.factorial();

            //While obj9 = new While();
            //obj9.method2();

            //ForEach forEach = new ForEach();
            //forEach.method3();

            //UsingReplace usingReplace = new UsingReplace();
            //usingReplace.replace("Hello#", "Hi@123", "Latha");

            //UsingSplit usingSplit = new UsingSplit();
            //usingSplit.split();

            UsingList usingList = new UsingList();
            usingList.List();
            //int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            //Exceptions e = new Exceptions();
            //Console.WriteLine("The returned value of given index: "+e.getInt(array1,2));

            //Lists lists = new Lists();
            //lists.IterateThroughLists();

            //Dictionary<int, string> My_dict1 =new Dictionary<int, string>();
            //My_dict1.Add(1, "Welcome");
            //My_dict1.Add(2, "Hii");
            //My_dict1.Add(3, "Hello");
            //My_dict1.Add(4, "Bye");

            //foreach (KeyValuePair<int, string> ele1 in My_dict1)
            //{
            //    Console.WriteLine("{0} and {1}",ele1.Key, ele1.Value);
            //}

            //My_dict1.Remove(4);//removes the value with corresponding key
            //My_dict1.Clear();// removes all keys and values 

            //foreach (KeyValuePair<int, string> ele1 in My_dict1)
            //{
            //    Console.WriteLine("After clear method: {0} and {1}", ele1.Key, ele1.Value);
            //}

            //if (My_dict1.ContainsKey(5) == true)
            //{
            //    Console.WriteLine("Key is found...!!");
            //}

            //else
            //{
            //    Console.WriteLine("Key is not found...!!");
            //}



            //if (My_dict1.ContainsValue("Hello") == true)
            //{
            //    Console.WriteLine("Value found");
            //}
            //else
            //{
            //    Console.WriteLine("Value not found");
            //}

            

            Console.ReadKey();
        }
    }
}
