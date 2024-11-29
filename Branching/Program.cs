using System;


namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemperature = 80;
            int roomTemperature = 70;

            if (currentTemperature == roomTemperature) 
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("Room temperature is warmer than current temperature.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }
            Console.ReadLine();


            //Terrary operator
            int currentTemperature1 = 80;
            int roomTemperature1 = 70;

            string comparisonResult = currentTemperature1 == roomTemperature1 ? "It is room temp." : "It is not room temp.";
            
            Console.WriteLine(comparisonResult);
            Console.ReadLine();


            // Small programe about the room temp
            int roomTemperature2 = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemperature2 = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature2 == roomTemperature2) 
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature2 > roomTemperature2) 
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (roomTemperature2 > currentTemperature2)
            {
                Console.WriteLine("It is colder than room temperature.");
            }
            else
            {
                Console.WriteLine("Uhhhhhhh..... something went wrong.");
            }

            Console.ReadLine();



            // Program what is your favorite number/ Terrary operator
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
