using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            string name1 = "Joe";
            string quote = "The man said, \"Hello\", Jesse. Jesse. \n Hello on a new line.  \n \t Hello on a tab.";
            string fileName = "C:\\Users\\Jesse";
            string fileName1 = @"C:\Users\Joe";


            bool trueOrFalse = name.Contains("f");
            bool trueOrFalse1 = name.Contains("e");

            bool trueOrFalse2 = name.EndsWith("f");
            bool trueOrFalse3 = name.EndsWith("e");

            int length = name.Length;

            name = name.ToUpper();
            name1 = name1.ToLower();

            // Change string
            string name2 = "Smith";
            name2 = "Conor";

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jesse");


            Console.WriteLine(quote);
            Console.WriteLine(fileName);
            Console.WriteLine(fileName1);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(trueOrFalse1);
            Console.WriteLine(trueOrFalse2);
            Console.WriteLine(trueOrFalse3);
            Console.WriteLine(length);
            Console.WriteLine(name);
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
