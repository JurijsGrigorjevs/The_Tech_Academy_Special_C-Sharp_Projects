using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    // Create a class - CalcMethods
    public class CalcMethods
    {
        // Create three methods, each of which will take one integer parameter in and return an integer. The methods should do some math operation on the received parameter.
        public static int Magic(int magic)
        {
            int magic_number = magic + 2;
            return magic_number;
        }

        public static int Super(int super)
        {
            int magNum = 4;
            int supNum = 8;
            int luckyNum = 7;
            int totalNum = (magNum + supNum + luckyNum) + super;
            return totalNum;
        }

        public static int Lucky(int lucky)
        {
            int magNum = 4;
            int supNum = 8;
            int luckyNum = 7;
            int happyNum = (magNum + supNum - luckyNum) + lucky;
            return happyNum;
        }
    }
}

