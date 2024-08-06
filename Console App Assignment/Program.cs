using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // DO WHILE loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                count++; // add one to count each time
            }

            while (count < 7); // Continue to loop until count reaches 5
            {

                // This is a  WHILE  loop
                int counting = 0;
                while (counting < 9) // Continue to loop until counting reaches 3
                {
                    Console.WriteLine("Counting numbers");
                    counting++; // add one to counting each time
                }
                Console.ReadLine();
            }
        }
    }
}
