using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICP_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymouse Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate");
            Console.WriteLine("$20");
            Console.ReadLine();
            Console.WriteLine("Hours worked per week");
            Console.WriteLine("40 hours");
            Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            Console.WriteLine("$40");
            Console.ReadLine();
            Console.WriteLine("Hours worked per week");
            Console.WriteLine("40 hours");
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine("$38,400");
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine("$76,800");
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = 38400 > 76800;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}
