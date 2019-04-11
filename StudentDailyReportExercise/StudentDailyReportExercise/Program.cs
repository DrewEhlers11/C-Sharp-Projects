using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReportExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

                Console.WriteLine("What course are you on?");
                string course = Console.ReadLine();

                    Console.WriteLine("What page number?");
                    int page = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Do you need help with anything? Please anwser 'true' or 'false'.");                     
                        bool help = Convert.ToBoolean(Console.ReadLine());

                            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
                            string positive = Console.ReadLine();

                                Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
                                string feedback = Console.ReadLine();

                                    Console.WriteLine("How many hours did you study today?");
                                    int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your anwsers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

                                

        }
    }
}
