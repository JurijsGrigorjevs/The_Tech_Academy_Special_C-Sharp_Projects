using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            // Same like array on top
            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };


            Console.WriteLine(numArray[3]);
            Console.WriteLine(numArray1[3]);


            // change array 
            int[] numArray2 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };
            numArray2[5] = 650;


            Console.WriteLine(numArray2[5]);


            // Create List
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            Console.WriteLine(intList[0]);

            List<string> intList1 = new List<string>();
            intList1.Add("Hello");
            intList1.Add("Joe");
            intList1.Remove("Joe");

            Console.WriteLine(intList1[0]);



            Console.ReadLine();
        }
    }
}
