using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program for calculating numbers that can be used in the lottery, but there is no guarantee that they can be winning.");
            Console.WriteLine("Calculating the magic number");
            Console.WriteLine("Please input your first number: ");
            int magic = Convert.ToInt32(Console.ReadLine());
            int magic_number = CalcMethods.Magic(magic);
            Console.WriteLine("You magic number " + magic_number + " !!!");
            Console.WriteLine("Calculating the super number");
            Console.WriteLine("Please input your second number: ");
            int super = Convert.ToInt32(Console.ReadLine());
            int super_number = CalcMethods.Super(super);
            Console.WriteLine("You super number " + super_number + " !!!");
            Console.WriteLine("Calculating the lucky number");
            Console.WriteLine("Please input your third number: ");
            int lucky = Convert.ToInt32(Console.ReadLine());
            int lucky_number = CalcMethods.Lucky(lucky);
            Console.WriteLine("You lucky number " + lucky_number + " !!!");
            Console.WriteLine("Thank you!");
            Console.ReadLine();

        }
    }
}


