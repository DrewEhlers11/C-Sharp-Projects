using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Packe Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
                decimal weight = Convert.ToInt32(Console.ReadLine());

                if (weight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToInt32(Console.ReadLine());
            
            decimal total;
            total = width + height + length;

                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (total <= 50)
                {
                    decimal quote;
                    quote = total * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "");
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
        }
    }
}
