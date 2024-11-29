using System;
using System.Collections.Generic;
using System.Text;


namespace Six_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
            // Create a console app
            // A one-dimensional array of string
            string[] yourName = { "My name is ", "My favorite color is " };
            string[] yourColor = { "!!!", ". I really like this color." };


            List<string> userResponses = new List<string>();
            // Ask the user to input some text
            Console.WriteLine("Please enter your first name: ");
            userResponses.Add(Console.ReadLine());
            Console.WriteLine("Please enter your favorite color: ");
            userResponses.Add(Console.ReadLine());


            // A loop that iterates through each string in the array and adds the user's text input to the end of each string. This step will not output anything to the console, but will update each array element by appending the user's text.
            for (int i = 0; i < yourName.Length; i++)
            {
                yourName[i] += userResponses[i];
                Console.WriteLine(yourName[i] + yourColor[i]);
            }
            Console.ReadLine();
            Console.WriteLine("What we got using strings: ");

            // Create a second loop that prints off each string in the array one at a time.
            for (int i = 0; i < yourName.Length; i++)
            {
                Console.WriteLine(yourName[i] + yourColor[i]);

                // Assignment Part 2
                // An infinite loop
                //for (int i = 0; i < yourName.Length; i++) 
                //{
                //    Console.WriteLine(yourName[i] + yourColor[i]);
                //    i--; // infinite loop - Fix the infinite loop so that it will execute properly.- This part of the code needs to be removed.

            }
            Console.ReadLine();


            // Assignment Part 3
            // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            Console.WriteLine("How are you feeling?");
            StringBuilder sb = new StringBuilder();
            sb.Append("FIN");
            while (sb.Length < 4)
            {
                sb.Append("E");
            }
            sb.Append("!");
            //Console.ReadLine();
            Console.WriteLine(sb);
            Console.ReadLine();


            // Another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            Console.WriteLine("Are You Okay?");
            StringBuilder strBul = new StringBuilder();
            strBul.Append("YE");
            while (strBul.Length <= 2)
            {
                strBul.Append("S");
            }
            strBul.Append("!");
            Console.WriteLine(strBul);
            Console.ReadLine();

            // Assignment Part 4
            // A list of strings where each item in the list is unique.
            List<string> brands = new List<string>() { "Jaguar", "Kia", "Lamborghini", "Maserati", "Nissan", "Porsche", "Tesla", "Honda", "Toyota", "Lexus", "Lotus", "BMW", "Fiat", "Volvo", "Ford", "Audi", "Jeep" };
            Console.WriteLine("Names of car brands");

            // Ask the user to input text to search for in the list.
            Console.WriteLine("Enter the name of the car brand: ");
            int position = 0;
            bool isValid = false;
            int index = 0;

            // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            while (!isValid)
            {
                int k = 0;
                string carrequest = Console.ReadLine();
                foreach (string brand in brands)
                {
                    if (carrequest == brand)
                    {
                        position = k + 1;
                        index = k;
                    }
                    k++;
                }
                // Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
                if (position == 0)
                {
                    Console.WriteLine("That is not a valid car brand. Please enter again: ");
                }
                // Add code that stops the loop from executing once a match has been found.
                else
                {
                    isValid = true;
                }
            }
            Console.WriteLine("Please wait... Index is: " + index + ". And...");
            Console.WriteLine("Position is: " + position);
            Console.ReadLine();


            // Assignment Part 5
            // A list of strings that has at least two identical strings in the list. 
            List<string> couriers = new List<string>() { "Uber Eats", "JUST EAT", "deliveroo", "Uber Eats", "JUST EAT", "deliveroo", "Uber Eats", "JUST EAT", "deliveroo" };
            Console.WriteLine("Welcome to Bob's Pizzeria! \nIf you want your order to be delivered within 10 - 20 minutes " + "\"Uber Eats\".\nIf you want your order to be delivered within 25 - 35 minutes \"JUST EAT\".\nIf you want your order to be delivered within 40 - 50 minutes \"deliveroo\".");
            // Ask the user to select text to search for in the list.
            Console.WriteLine("Please enter courier delivery: ");
            string delivery = Console.ReadLine();
            while (!(delivery == "Uber Eats" || delivery == "JUST EAT" || delivery == "deliveroo"))
            {
                // Code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list. 
                Console.WriteLine("Please enter one of the courier delivery:");
                delivery = Console.ReadLine();
            }
            Console.WriteLine("Delivery that match your choice will be made:");
            // Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
            for (int c = 0; c < couriers.Count; c++)
            {
                if (delivery == couriers[c])
                {
                    Console.WriteLine(c);
                }
            }
            Console.ReadLine();


            // Assignment Part 6
            // Create a list of strings that has at least two identical strings in the list.
            List<string> colors = new List<string>() { "black", "blue", "yellow", "black", "orange", "yellow", "gray", "green", };
            List<string> sameColor = new List<string>();
            Console.WriteLine("Car color:");
            // Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list. 
            foreach (string color in colors)
            {
                Console.WriteLine(color);
                if (sameColor.Contains(color))
                {
                    Console.WriteLine("This color was already there.\nUse the car model for identification.");
                }
                else
                {
                    Console.WriteLine("This color was not repeated.");
                }
                sameColor.Add(color);
            }
            Console.ReadLine();
        }
    }
}
