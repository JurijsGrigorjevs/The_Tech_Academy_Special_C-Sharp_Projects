//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleasee enter in your first name.");
            string date = DateTime.Today.ToString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\Public\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);


            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble((line));
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);



            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
    
}

