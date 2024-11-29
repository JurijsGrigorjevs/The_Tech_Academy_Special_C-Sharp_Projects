using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {   // Create an Employee class with Id, FirstName and LastName properties. 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator to compare employee objects by Id
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check if both objects are null or non-null
            if (employee1 is null && employee2 is null) 
            { 
                return true;
            }

            if (employee1 is null ||  employee2 is null) 
            {
                return false;
            }

            return employee1.Id == employee2.Id;
        }
        // Overload != operator to compare employee objects by Id
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }

}
