using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age");
                int userinput1 = Convert.ToInt32(Console.ReadLine());
                if (userinput1 < 0)
                {
                    Console.WriteLine("Please enter a number that is not negative or not zero.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine(userinput1);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter your age in numerical values and only a whole number.");
                Console.ReadLine();
                return;
            }
        }
    }
}
