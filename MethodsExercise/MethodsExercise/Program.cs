using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            method Meatloaf = new method();
            
            Console.WriteLine("Please enter two numbers after the other.");
            int userinput1 = Convert.ToInt32(Console.ReadLine());
            int userinput2 = Convert.ToInt32(Console.ReadLine());

            Meatloaf.Calculate(input1: userinput1,input2: userinput2); //Can switch input1 with input2 if I want that first.
            Console.ReadLine();
           
        }
    }
}
