using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();

            Console.WriteLine("Please enter a number");
            int userinput1 = Convert.ToInt32(Console.ReadLine());

            
            int results1 = method.Number(input1: userinput1);
            Console.WriteLine(results1);
            Console.ReadLine();

            //---------------------

            Method method2 = new Method();

            Console.WriteLine("Please enter a decimal number");
            double userinput2 = Convert.ToDouble(Console.ReadLine());

            
            double results2 = method2.Number2(input2: userinput2);
            Console.WriteLine(results2);
            Console.ReadLine();

            //---------------------

            Method method3 = new Method();

            Console.WriteLine("Please enter a number 1-5");
            string stringNumber = Console.ReadLine();


            
            int results = method3.StringMethod(stringNumber);
            Console.WriteLine(results);
            Console.ReadLine();


            //int result = Convert.ToInt32(Console.ReadLine());

            //if (userinput3 == "one")
            //{
            //    Console.WriteLine(result + 1);
            //    Console.ReadLine();
            //}
            //else if (userinput3 == "two")
            //{
            //    Console.WriteLine(result + 2);
            //    Console.ReadLine();
            //}
            //else if (userinput3 == "three")
            //{
            //    Console.WriteLine(result + 3);
            //    Console.ReadLine();
            //}
            //else if (userinput3 == "four")
            //{
            //    Console.WriteLine(result + 4);
            //    Console.ReadLine();
            //}
            //else if (userinput3 == "five")
            //{
            //    Console.WriteLine(result + 5);
            //    Console.ReadLine();
            //}
        }
    }
}
