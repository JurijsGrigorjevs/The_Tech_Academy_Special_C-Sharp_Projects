using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    public class Program
    {
        // Create a struct called Number
        public struct Number
        {
            // Give it the property “Amount” and have it be of data type decimal.
            public decimal Amount { get; set; }
        }
            static void Main(string[] args)
            {
            // In the Main() method, create an object of data type Number and assign an amount to it.
            Number num = new Number();
            num.Amount = 567.456m;

            Console.WriteLine("The amount is: " + num.Amount);
            Console.ReadLine();
        }
    }
}
