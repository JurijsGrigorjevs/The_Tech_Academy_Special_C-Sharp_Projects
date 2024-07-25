using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.ReadLine();

            //int total1 = 5 + 10;
            //int othertotal = 12 + 22;
            //int combined = total1 + othertotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient1 = 100.0 / 14.0;
            //Console.WriteLine(quotient1);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int remainder1 = 11 % 2;
            //Console.WriteLine(remainder1);
            //Console.ReadLine();

            //int num1 = 200 / 3;
            //Console.WriteLine(num1);
            //Console.ReadLine();


            bool trueOrFalse = 12 < 5;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();


            int roomTemperature = 70;
            int currentTemperature = 72;
            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

            int roomTemperature1 = 70;
            int currentTemperature1 = 70;
            bool isWarm1 = currentTemperature1 >= roomTemperature1;
            Console.WriteLine(isWarm1);
            Console.ReadLine();

            int roomTemperature2 = 70;
            int currentTemperature2 = 70;
            bool isWarm2 = currentTemperature2 != roomTemperature2;
            Console.WriteLine(isWarm2);
            Console.ReadLine();

        }
    }
}
