using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            double number = Convert.ToDouble(Console.ReadLine());

            double[] hours = { number };


            foreach (double hour in hours)
            {
                Console.WriteLine("{0} + " + number + " hour(s) = {2}", DateTime.Now, hours,
                DateTime.Now.AddHours(hour));
            }
            Console.ReadLine();

        }
    }
}
