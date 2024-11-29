using System;


namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathsOps class
            MathsOperation mathOp = new MathsOperation();


            // Call the method in the class, passing in two numbers
            mathOp.MathsOps(6, 7);

            // Call the method in the class, specifying the parameters by name
            mathOp.MathsOps(number1: 5, number2: 9);

            
            Console.ReadLine();
        }
    }
}
