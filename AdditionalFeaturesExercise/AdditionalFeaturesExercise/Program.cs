using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Day = "Friday";

            var Month = "January";

            Console.WriteLine("Please enter a number when its going to be Friday.");
            int getNumber = Convert.ToInt32(Console.ReadLine());

            Class1 a = new Class1(Day, getNumber);

            Console.WriteLine("In {0} days it will be {1}.", getNumber, Day);
            Console.ReadLine();

        }
    }
}
