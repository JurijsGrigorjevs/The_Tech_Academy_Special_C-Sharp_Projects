using System;


namespace Daily_Report_Assignment
{
    class Program 
    {
        static void Main(string[] args)
        {   // Writes the specified string value, followed by the current line terminator, to the standard output stream
            Console.WriteLine("Academy of learning Career College.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            // Reads the next line of characters from the standard input stream
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            // Converts the specified string representation of a number to an equivalent 32-bit signed integer
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            // Converts the specified string representation of a logical value to its boolean equivalent.
            bool needHelpBoolean = bool.Parse(needHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            // Converts the specified string representation of a number to an equivalent 32-bit signed integer
            int studyHoursNumber = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
