using System;


namespace ConstructorAssignment
{
    public class Chain
    {
        // Constructor if one parameter, a float, is provided
        public Chain(float number1) : this(number1, "Jurijs")
        {
            Console.WriteLine(number1 + " and your default name is " + Name);
        }
        // Constructor if one parameter, a string, is provided
        public Chain(string name1) : this(48, name1)
        {
            Console.WriteLine(name1 + " and your default favorite number is " + Number);
        }
        // Constructor if both parameters, a string and a float, are provided
        public Chain(float number, string name)
        {
            Name = name;
            Number = number;
        }

        private string Name { get; set; }
        private float Number { get; set; }
    }
}
