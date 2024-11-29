using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // int array
            int[] testScores = { 59, 49, 29, 88, 95, 65, 34, 78 };
             for (int i = 0; i < testScores.Length; i++) 
            {
                if (testScores[i] > 60)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }
            

            // string array
            string[] names = { "Joe", "Bob", "Arron", "Jurijs", "Alma" };
             for (int k = 0; k < names.Length; k++) 
             {
                if (names[k] == "Alma")
                {
                    Console.WriteLine(names[k]);
                }
             }
            

            // string array
            string[] names1 = { "Joe", "Bob", "Arron", "Jurijs", "Alma" };
            for (int j = 0; j < names.Length; j++)
            {
                 Console.WriteLine(names[j]);    
            }

            // list - int
            List<int> testScore1 = new List<int>();
            testScore1.Add(67);
            testScore1.Add(47);
            testScore1.Add(37);
            testScore1.Add(57); 
            testScore1.Add(77);
            testScore1.Add(87);
            testScore1.Add(97);

            foreach (int score in testScore1)
            {
                if (score > 50)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }

            // list - string
            List<string> names2 = new List<string>() { "Alma", "Jurijs", "Joe", "Bob" };
            {
                foreach (string name in names2)
                {
                    if (name == "Alma")
                    {
                        Console.WriteLine(name);
                    }
                }
            }

            List<string> names3 = new List<string>() { "Alma", "Jurijs", "Joe", "Bob" };
            {
                foreach (string name in names3)
                {
                        Console.WriteLine(name); 
                }
            }


            // list - int + new int and count
            List<int> testScores2 = new List<int>() { 55, 44, 33, 23, 78, 58, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score1 in testScores2)
            {
                if (score1 > 45)
                {
                    passingScores.Add(score1);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.WriteLine();

            Console.ReadLine();
        }   
    }
}
