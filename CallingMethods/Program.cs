using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've encountered Groznyi the Brigand and he launches a surprise attack.");
            Console.WriteLine("Input your defense stat: ");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethods.Defense(defense);
            Console.WriteLine("You have taken " + enemy_damage + " HP of damage");
            Console.WriteLine("Your healer, Serra is near by. She heals you with her staff.");
            Console.WriteLine("Input your healer's magic stat: ");
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethods.Heal(magic);
            Console.WriteLine("You have been healed for " + hitpoints + " HP.");
            Console.WriteLine("How it's your turn to counter attack.");
            Console.WriteLine("Input your strength stat: ");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods.Attack(strength);
            Console.WriteLine("You have landed a critical attack and dealt " + damage + " HP worth of damage.");
            Console.ReadLine();
        }
    }
}
