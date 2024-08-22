using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathsMethods class and call the one method, passing in an integer
            MathsMethods maths = new MathsMethods();

            // Call the first method with an int parameter
            Console.WriteLine("Integer");
            Console.WriteLine(maths.MathsOperation(11));

            // Call the second method with a decimal parameter
            Console.WriteLine("Decimal");
            Console.WriteLine(maths.MathsOperation(6.5m));

            // Call the third method with a string parameter
            Console.WriteLine("String");
            Console.WriteLine(maths.MathsOperation("9"));
        }
    }
}
