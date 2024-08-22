using System;


namespace MethodClassAssignment
{
    // Create a class - MathsOperation
    class MathsOperation
    {
        // Create a void method that takes two integers as parameters.
        public void MathsOps(int number1, int number2)
        {
            // Perform a mathematical operation on the first integer
            int result = number1 * 8;

            // Display the result and the second integer
            Console.WriteLine("The result of a mathematical operation on the first integer: " + result);
            Console.WriteLine("Display the second integer: " + number2);
        }
    }
}
