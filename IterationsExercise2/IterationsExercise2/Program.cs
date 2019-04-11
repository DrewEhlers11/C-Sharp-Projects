using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] things = { "Pizza", "Soup", "Soda", "Carrot", "Steak" };


            Console.WriteLine("Please type a word.");
            string input1 = Console.ReadLine();

            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine(things[i] + input1);

            }
            Console.ReadLine();

            for (; ; )
            {
                Console.WriteLine();
                break;
            }
            Console.ReadLine();



            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine(things[i] + input1);

            }
            Console.ReadLine();



            for (int i = 0; i <= things.Length - 1; i++)
            {
                Console.WriteLine(things[i] + input1);

            }
            Console.ReadLine();

            List<string> unique = new List<string>(new string[] { "Pizza", "Soup", "Soda", "Carrot", "Steak" });
            //unique.Add("Pizza");
            //unique.Add("Pie");
            //unique.Add("Soup");
            //unique.Add("Soda");
            //unique.Add("Cake");

            Console.WriteLine("Please enter the food you'd like to search for.");
            string input2 = Console.ReadLine();

            for (int j = 0; j <= 4; j++)
            {
                if ((unique[j] == input2) && (j <= 4))

                {
                    Console.WriteLine("This food is number " + j + " in the order.");
                }
                else if ((unique[j] != input2) && j == 4)
                {

                    Console.WriteLine("This food is not on the order.");

                }

            }
            Console.ReadLine();






            List<string> unique2 = new List<string>(new string[] { "Pizza", "Soup", "Soda", "Carrot", "Pizza" });

            Console.WriteLine("Please enter the food you'd like to search for from the choices which have been listed.");
            string input3 = Console.ReadLine();


            for (int p = 0; p <= 4; p++)
            {
                if ((unique2[p].Contains(input3)) && (p <= 4))
                {
                    Console.WriteLine("This food will be served on rounds " + p + " tonight.");
                }
                else 
                {
                    Console.WriteLine("This food is not on the order.");
                }
            }
            Console.ReadLine();







            List<string> unique3 = new List<string>(new string[] { "Meat", "Soup", "Soda", "Carrot", "Meat" });


            List<string> list = new List<string>();
            


            Console.WriteLine("Please enter the food you'd like to search for from the choices which have been listed.");
            Console.ReadLine();


            foreach (string name in unique3)
            {
                if (list.Contains(name))
                {
                    Console.WriteLine(name + " already appears in the list.");
                }
                else
                {
                    list.Add(name);
                    Console.WriteLine("This food is not on the order.");
                }
            }

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }     
            Console.ReadLine();


        }
    }
}