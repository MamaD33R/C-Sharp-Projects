using System;
using System.Collections.Generic;




    class Program
    {
        static void Main(string[] args)
        {
        //    int[] testScores = { 98, 99, 86, 70, 82, 55, 20, 99, 94 }; 

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Kaia", "Shauna", "Miri", "Hannie" };
        // declare variable and name it; how many times to go through this loop; adding one everytime 
        // to variable until it reaches array length
        // in '}' define what to do 

        //for (int k = 0; k < names.Length; k++)
        //{
        //    if (names[k] == "Kaia")
        //    {
        //        Console.WriteLine(names[k]);
        //    }
        //}

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(77);
        //testScores.Add(85);
        //testScores.Add(89);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score:" + score);
        //    }
        //}

        //List<string> names = new List<string>() { "Kaia", "Shauna", "Miri", "Hannie" };

        //foreach (string name in names)
        //{

        //        Console.WriteLine(name);

        //}

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 88, 99 };
        List<int> passingScores = new List<int>();
        // you can make blank lists, unlike arrays
        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);

        Console.ReadLine();
        }
    }

