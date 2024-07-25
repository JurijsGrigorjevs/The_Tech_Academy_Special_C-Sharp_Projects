using System;




class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Acme Accounting Systems \nRemember, we're  \"accounting\" on you!");
        Console.ReadLine();

                     // Addition
             int num1 = 75;
             int num2 = 88;
             int total = num1 + num2;
             Console.WriteLine(total);

             // Subtractio
             int num3 = 45;
             int num4 = 55;
             int difference = num3 - num4;
             Console.WriteLine(difference);

             // Multiplication
             int num5 = 99;
             int num6 = 33;
             int product = num5 * num6;
             Console.WriteLine(product);

             // Division
             int num7 = 81;
             int num8 = 8;
             int quotient = num7 / num8;
             Console.WriteLine(quotient);

                int num9 = 7;
               float num10 = 5.5f;
               float total1 = num9 + num10;
               int total2 = num9 + (Int32)num10;
               Console.WriteLine(total1);
               Console.WriteLine(total2);

                // Math casting
                double num11 = 7.03230923;
                float num12 = 5.9f;
                double total3 = num11 + num12;
                Console.WriteLine(total3);

                double num13 = 7.03230923;
                float num14 = 5.9f;
                float total4 = (float)num13 + num14;
                Console.WriteLine(total4);
    }
}

