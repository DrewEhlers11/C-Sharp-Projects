using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 50;
            Console.WriteLine(num1 * num2);
            Console.ReadLine();

            int num3 = 25;
            int num4 = 25;
            Console.WriteLine(num3 + num4);
            Console.ReadLine();

            double divide = 75 / 12.5;
            Console.WriteLine(divide);
            Console.ReadLine();

            bool trueOrFalse = 65 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            int remainder = 10 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
