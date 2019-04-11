using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsExercise
{
    public class Program
    {
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main()
        {
            try
            {
                DaysOfTheWeek day = new DaysOfTheWeek();

                Console.WriteLine("Please enter the current day of the week");
                string userinput1 = Convert.ToString(Console.ReadLine());

                DaysOfTheWeek value = day;

                DaysOfTheWeek test = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userinput1);

                Console.WriteLine(test);
                Console.ReadLine();


            }

            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }
        }
    }
}
