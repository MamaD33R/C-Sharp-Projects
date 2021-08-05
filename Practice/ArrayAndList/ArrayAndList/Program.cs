using System;
using System.Collections.Generic;




    class Program
    {
        static void Main(string[] args)
        {


        List<string> intList = new List<string>(); 

        intList.Add("Hello");
        intList.Add("Kaia");

        intList.Remove("Kaia");


        Console.WriteLine(intList[0]);
        Console.ReadLine();

        

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; // easier version of created array above

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600 }; // faster version than previous

        //numArray2[5] = 650; // to change parts of array, but limited to it's size

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();


        }
    }

