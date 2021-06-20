using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        string[] stringArray = { "hello", "it's very", "nice", "to", "meet you" };
        Console.WriteLine("Please select a number: 0-4 ");
        int array = Convert.ToInt32(Console.ReadLine());
        if ( array > 4)
        {
            Console.WriteLine("Please enter a correct number.");
            
            
        }
        else
        {
            Console.WriteLine(stringArray[array]); 
        }
        
        

        int[] intArray = { 5, 60, 15, 400, 20 };
        Console.WriteLine("Please select a number: 0-4");
        int array2 = Convert.ToInt32(Console.ReadLine());

        if ( array2 > 4)
        {
            Console.WriteLine("Please enter a correct number.");
        }

        else
        {
            Console.WriteLine(intArray[array2]);
        }
        
        

        List<string> flower = new List<string>();

        flower.Add("tulip");
        flower.Add("rose");
        flower.Add("daisy");
        flower.Add("daffodil");

        Console.WriteLine("Please select a number: 0-3 ");
        int flower2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(flower[flower2]);
        Console.ReadLine();



        }
    }

