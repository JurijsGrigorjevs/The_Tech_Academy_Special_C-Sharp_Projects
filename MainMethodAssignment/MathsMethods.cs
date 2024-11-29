using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{   
    // Create a class.
    public class MathsMethods
    {
        // Create a first method that will take in an integer
        // create a maths opetation for this integer - addition
        public int MathsOperation( int number)
        {
            return number + 11;
        }

        // Create a second method to the class with the same name that will take in a decimal, create a different maths operation for it.
        public int MathsOperation( decimal number )
        {
            // Convert the value of the specified decimal number to an equivalent 32-bit signed integer 
            int num = Convert.ToInt32( number );
            return num * 15;
        }

        // Create a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different maths operation to it.
        public int MathsOperation( string number )
        {
            // Converts the specified string representation of a number to an equivalent 32-bit signed integer 
            int num = Convert.ToInt32( number );
            return num % 2;

        }
    }
}
