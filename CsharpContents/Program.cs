﻿using CsharpContents.Access_specifiers;
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

            //UsingList usingList = new UsingList();
            //usingList.List();
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            Exceptions e = new Exceptions();
            Console.WriteLine("The returned value of given index: "+e.getInt(array1,2));
            Console.ReadKey();
        }
    }
}
