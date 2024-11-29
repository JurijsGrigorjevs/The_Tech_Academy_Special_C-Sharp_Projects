using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts the user to enter a number.
            Console.WriteLine("Please, enter any number: ");
            string number = Console.ReadLine();

            // Writes that number to a text file.
            File.WriteAllText(@"C:\Users\Public\Input Assignment\InputAssignment\test_log.txt", number);// Can use a  File.WriteAllText("C:\\Users\\Public\\TwentyOne\\log_text_test\\test_log.txt", text);
            // Prints the text file back to the user.
            string number1 = File.ReadAllText(@"C:\Users\Public\Input Assignment\InputAssignment\test_log.txt");
            Console.WriteLine("Your number: {0}", number1);

            Console.WriteLine("Thank you!");
            Console.Read();
        }
    }
}
