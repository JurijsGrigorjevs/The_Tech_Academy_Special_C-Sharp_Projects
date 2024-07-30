using System;


namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Console Application Assignment");
            {
                // Takes an input from the user, multiplies it by 50, then prints the result to the console.(Note: make sure your code can take inputs larger than 10,000,000).
                Console.WriteLine("Enter any number between 1 and 100 and your number will be multiplied by 50.");

                while (true)
                {
                    string multNum1 = Console.ReadLine();
                    int multNum2;

                    // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded
                    bool isMultNum = int.TryParse(multNum1, out multNum2);

                    if (isMultNum && multNum2 >= 1 && multNum2 <= 100)
                    {
                        Console.WriteLine("You entered the correct number and now your number will be multiplied by 50.");
                        int multNum3 = Convert.ToInt32(multNum1) * 50;
                        Console.WriteLine(multNum3);
                        break; // Exit the loop if input is valid
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    }
                }
            }


            // Takes an input from the user, add 25 to it, then prints the result to the console.
            Console.WriteLine("Enter any number from 1 to 100 and 25 will be added to your number.");

            while (true)
            {
                string addNum1 = Console.ReadLine();
                int addNum2;

                // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded
                bool isAddNum = int.TryParse(addNum1, out addNum2);

                if (isAddNum && addNum2 >= 1 && addNum2 <= 100)
                {
                    Console.WriteLine("You entered the correct number and now 25 will be added to your number.");
                    int addNum3 = Convert.ToInt32(addNum1) + 25;
                    Console.WriteLine(addNum3);
                    break; // Exit the loop if input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }
            }


            // Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Enter any number from 1 to 100 and your number will be divides by 12.5.");

            while (true)
            {
                string divNum1 = Console.ReadLine();
                double divNum2;

                // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded
                bool isDivNum = double.TryParse(divNum1, out divNum2);

                if (isDivNum && divNum2 >= 1 && divNum2 <= 100)
                {
                    Console.WriteLine("You entered the correct number and now your number will be divides by 12.5.");
                    double divNum3 = Convert.ToInt32(divNum1) / 12.5;
                    Console.WriteLine(divNum3);
                    break; // Exit the loop if input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }
            }


            // Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            Console.WriteLine("Enter any number from 1 to 100 and it will now be checked to see if it is greater than 50.");

            while (true)
            {
                string grtNum1 = Console.ReadLine();
                int grtNum2;

                // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded
                bool isGrtNum = int.TryParse(grtNum1, out grtNum2);

                if (isGrtNum && grtNum2 >= 1 && grtNum2 <= 100)
                {
                    Console.WriteLine("You entered the correct number, now check if it is greater than 50.");
                    bool trueOrFalse = grtNum2 > 50;
                    Console.WriteLine(trueOrFalse.ToString());
                    break; // Exit the loop if input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }
            }


            // Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).
            Console.WriteLine("Enter any number from 1 to 100.");

            while (true)
            {
                string remNum1 = Console.ReadLine();
                int remNum2;

                // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded
                bool isRemNum = int.TryParse(remNum1, out remNum2);

                if (isRemNum && remNum2 >= 1 && remNum2 <= 100)
                {
                    Console.WriteLine("You entered the correct number and now number be divides by 7 and then the remainder will be printed to the console.");
                    int remNum3 = Convert.ToInt32(remNum1) % 7;
                    Console.WriteLine(remNum3);
                    break; // Exit the loop if input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }
            }
        }

    }


    }

    
