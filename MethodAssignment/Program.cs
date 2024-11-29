using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MathsOps class
            MathsOps mathsOperation = new MathsOps();
            // Ask the user to input the first number for the first parameter
            Console.WriteLine("Please enter an integer: ");
            int number_first = Convert.ToInt32(Console.ReadLine());

            // Ask the user to input the second number for the second parameter or press enter
            Console.WriteLine("Please enter a second integer, or just press enter (don't need to enter anything for the second number): ");
            try
            {
                // Call a method with 2 parameters if both parameters are specified
                int number_second = Convert.ToInt32(Console.ReadLine());
                int results = mathsOperation.MathsOperation(number_first, number_second);
                Console.WriteLine(number_first + " + " + number_second + " = " + results);
            }
            catch
            {
                // Call method with one parameter if only is specified
                int results = mathsOperation.MathsOperation(number_first);
                Console.WriteLine(number_first + " + Default - 7 = " + results);
            }
            Console.ReadLine();
        }
    }
}
