using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            method1 UserResult = new method1();

            Console.WriteLine("Please pick a number to do some math operations on");
            int userinput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UserResult.Calculate1(userinput1));
            Console.ReadLine();

            

            Console.WriteLine("Please pick another number to do some math operations on");
            int userinput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UserResult.Calculate2(userinput2));
            Console.ReadLine();



            Console.WriteLine("Please pick another number to do some math operations on");
            int userinput3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UserResult.Calculate3(userinput3));
            Console.ReadLine();

        }
    }
}
