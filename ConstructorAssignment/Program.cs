using System;
using System.Globalization;


namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable
            const string constName = "Your name is: ";
            const string constNum = "Your favorite number is: ";
            Console.WriteLine("Enter your name or favorite number: ");

            // Create a variable using the var keyword
            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x))
            {
                Console.WriteLine(constNum);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(constName);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}
