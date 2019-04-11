using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanOperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please anwser with 'true' or 'false'.");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());



            if ((age >= 15) && (dui = true) && (tickets <= 3))
            {
                Console.WriteLine("You qualify!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You do not qualify");
                Console.ReadLine();
                Console.WriteLine("Possible causes:");
                Console.ReadLine();
                Console.WriteLine("You are not 15 or older, or you have been arrested from a DUI, or you have more than 3 tickets.");
                Console.ReadLine();
            }
        }
    }
}
