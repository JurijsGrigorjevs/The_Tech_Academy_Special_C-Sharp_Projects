using System;


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception Handling
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            Console.ReadLine();


            // Own messages
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree1 = numberOne1 / numberTwo1;
                Console.WriteLine(numberOne1 + " divided by " + numberTwo1 + " equals " + numberThree1);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }

            Console.ReadLine();

            // Own message with return
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree1 = numberOne1 / numberTwo1;
                Console.WriteLine(numberOne1 + " divided by " + numberTwo1 + " equals " + numberThree1);
                Console.ReadLine();
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex2)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
