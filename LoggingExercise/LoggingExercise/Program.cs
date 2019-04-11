using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");
            var userinput1 = Console.ReadLine();
            string file = userinput1;

            File.WriteAllText(@"C:\Users\Drew\Desktop\Logs\log.txt", file);

            string file = File.ReadAllText(@"C:\Users\Drew\Desktop\Logs\log.txt");

        }
    }
}
