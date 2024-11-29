using System;
using System.Collections.Generic;


namespace ConsoleAppStringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a list of integers
            List<int> numList = new List<int>() { 3, 5, 6, 33, 43, 243, 325, 5535, 43433, 242343, 3453322, 65435343 };
            // Ask the user for a number to divide each number in the list by
            bool iValid = false;
            // Ask the user for a number to divide each number in the list by. 
            while (!iValid)
            {
                // A try/catch block to give error message
                try
                {
                    Console.WriteLine("Please enter the number by which to divide the list above: ");
                    float numDiv = float.Parse(Console.ReadLine());
                    if (numDiv == 0)
                    {
                        Console.WriteLine("Please enter a number other than 0");
                    }
                    // Dividing each number in the list by the number entered by the user
                    else
                    {
                        foreach (int num in numList)
                        {
                            float listDivide = num / numDiv;
                            Console.WriteLine(num + "/" + listDivide + " = " + listDivide);
                        }
                        iValid = true;
                    }
                }
                // Catch block to display error message
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            // Message to let the user know the program has exited the try/catch block
            Console.WriteLine("The program has exited the try/catch block");
            Console.ReadLine();
        }
        
    }
}
