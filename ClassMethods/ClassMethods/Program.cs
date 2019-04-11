using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method1 = new Method();
           

            Console.WriteLine("Please enter a number");
            int userinput1 = Convert.ToInt32(Console.ReadLine());

            method1.Method1(userinput1);
            Console.ReadLine();




            Console.WriteLine("Please enter another number");
            int userinput2 = Convert.ToInt32(Console.ReadLine());

            method1.Method1(userinput2);
            Console.ReadLine();
        }
    }
}
