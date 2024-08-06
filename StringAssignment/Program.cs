using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenates three strings
            string name = "Joe";
            string name1 = "My name is ";
            string name2 = " and I line on the planet.";

            Console.WriteLine(name1 + name + name2);


            // Converts a string to uppercase
            string upperCase = "I like to program";
            upperCase = upperCase.ToUpper();

            Console.WriteLine(upperCase);


            // Creates a Stringbuilder and builds a paragraph of text, one sentence at a time
            StringBuilder sb = new StringBuilder();
            sb.Append("The people upstairs all practise ballet\r\nTheir living room is a bowling alley\r\nTheir bedroom is full of conducted tours.\r\nTheir radio is louder than yours.\r\n\t Thank you!");

            Console.WriteLine(sb);
        }
    }
}
