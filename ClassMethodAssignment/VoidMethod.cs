using System.Linq;

namespace ClassMethodAssignment
{
    public class VoidMethod
    {
        public int Value { get; set; }

        // Example method to perform some operation
        public void MathOp(int dividend)
        {
            Value = dividend * 2; // Example operation
        }

        // Example method with an output parameter
        public string StringCounter(string input, out int count)
        {
            count = input.Length;
            return $"The input phrase has {count} characters.";
        }

        // Overloaded method
        public int StringCounter(string input)
        {
            return input.Length;
        }

        // Static method to count 'i's in a string
        public static int IFinder(string input)
        {
            int count = input.Count(c => c == 'i' || c == 'I');
            return count;
        }
    }
}