using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentData
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the database context and ensure it's disposed of correctly.
            using (var db = new CollageContext())
            {

                // Enter first name of the student
                Console.Write("Enter a student First Name: ");
                Console.WriteLine();
                var firstName = Console.ReadLine();

                // Enter last name of the student
                Console.Write("Enter a student Last Name: ");
                Console.WriteLine();
                var lastName = Console.ReadLine();

                // Declare a DateTime variable to hold the student's date of birth.
                DateTime dateOfBirth;

                while (true)
                {
                    Console.Write("Enter a student's Date Of Birth (dd/MM/yyyy): ");
                    Console.WriteLine();
                    if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateOfBirth))
                    {
                        break; // Valid date entered, exit the loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Please enter the date in dd/MM/yyyy format.");
                    }
                }

                // Prompt the user to enter the student's grade
                Console.Write("Enter a student's Grade: ");
                Console.WriteLine();
                var gradeName = Console.ReadLine(); 
                // Find or create the grade
                var grade = db.Grades.SingleOrDefault(g => g.GradeName == gradeName) ?? new Grade { GradeName = gradeName };


                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dateOfBirth,
                    Grade = grade
                };

                // Add the grade if it is new if
            if (grade.GradeId == 0)
                {
                    db.Grades.Add(grade);
                }

                // Add the new student to the Students table in the database.
                db.Students.Add(student);
                db.SaveChanges();

                // Display all grades and students
                Console.WriteLine("\n--------------------- Grades ------------------------");
                // Query the database for all grades and their corresponding students.
                var gradesQuery = from g in db.Grades
                                  orderby g.GradeName
                                  select new
                                  {
                                      GradeName = g.GradeName,
                                      Students = db.Students.Where(s => s.Grade.GradeId == g.GradeId).OrderBy(s => s.LastName)
                                  };
                // Iterate over each grade and display the grade name and its students.
                foreach (var gradeGroup in gradesQuery)
                {
                    Console.WriteLine($"\nGrade: {gradeGroup.GradeName}");
                    foreach (var studentInGrade in gradeGroup.Students)
                    {
                        Console.WriteLine($"  - {studentInGrade.FirstName} {studentInGrade.LastName} ({studentInGrade.DateOfBirth:dd/MM/yyyy})");
                    }
                }

                Console.WriteLine("\n-----------------------------------------------------");
            }

        }
    }
}
    

