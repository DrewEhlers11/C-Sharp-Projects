using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee()
            //{
            //    FirstName = "Sample",
            //    LastName = "Student",
            //    Id = 1,
            //};

            //Employee employee2 = new Employee()
            //{
            //    FirstName = "Bob",
            //    LastName = "Joe",
            //    Id = 2,
            //};

            //Console.WriteLine("Do these two employees have the same ID number?");
            //Console.ReadLine();

            //Console.WriteLine(employee == employee2);
            //Console.ReadLine();

            Employee<string> Bob = new Employee<string>();
            Employee<int> Joe = new Employee<int>();

            List<string> things = new List<string>();
            things.Add("Cheese");
            things.Add("Meat");
            things.Add("Milk");
            Bob.EmployeeList = things;


            List<int> things2 = new List<int>();
            things2.Add(1);
            things2.Add(2);
            things2.Add(3);
            Joe.EmployeeList = things2;

            foreach (string thing in things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in things2)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();


            //employee.SayName();
            //Console.ReadLine();



            //Employee Quit = new Employee();
            //Quit.Quit();


            //employee.FirstName = new List<string>();
        }
    }
}
