using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(4);
            list.Add(6);
            list.Add(8);
            list.Add(10);

            list.ForEach(Console.WriteLine);
            Console.WriteLine("Please enter a number");
            

            var i = 5;
            

            try
            {
                int input1 = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i < list.Count; i++)
                { 
                    Console.WriteLine(list[i] / input1);
                    Console.ReadLine();
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
