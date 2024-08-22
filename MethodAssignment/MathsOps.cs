using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    // Create a class
    class MathsOps
    {
        // Create a method that takes two integers as parameters. Make one of them optional. 
        public int MathsOperation(int i, int j = 7)
        {
            // Have the method do a math operation and return an integer result
            int result = i + j;
            return result;
        }

    }
}
