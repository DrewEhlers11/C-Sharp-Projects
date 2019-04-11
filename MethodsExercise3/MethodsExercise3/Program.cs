using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method1 = new Method();


            Console.WriteLine("Please enter two numbers, one at a time. The second number may not have anything in it.");
            int userinput1 = Convert.ToInt32(Console.ReadLine());
            var userinput2 = Console.ReadLine();

            var results = userinput1 + userinput2;

            method1.Numbers(input1: userinput1);
            Console.WriteLine(results);
            Console.ReadLine();

            if (userinput2 == null)
            {
                Console.WriteLine("You have entered nothing");
                Console.ReadLine();
            }


        }
    }
}
