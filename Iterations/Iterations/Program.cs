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
            string[] things = {"Pizza", "Car", "Computer", "Carrot", "Steak" };
              

            Console.WriteLine("Please type a word.");
            string input1 = Console.ReadLine();

            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine(things[i] + input1 );
                
            }
            Console.ReadLine();

            for (; ;)
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

            List<string> unique = new List<string>(new string[] { "Pizza", "Pie", "Soup", "Soda", "Cake" });
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
                else if ((unique[j] != input2) && j==4)
                {
                    
                    Console.WriteLine("This food is not on the order.");
                   
                }
                
            }
            Console.ReadLine();



            List<string> unique2 = new List<string>(new string[] { "Pizza", "Pie", "Soup", "Soda", "Pizza" });

            Console.WriteLine("Please enter the food you'd like to search for.");
            string input3 = Console.ReadLine();


            for (int p = 0; p <= 4; p++)
            {
                if ((unique2[p] == input3) && (p <= 4))
                {
                    Console.WriteLine("This food will be served on rounds " + p + " tonight.");
                    Console.WriteLine(" [0]" + unique2[0] + " [1]" + unique2[1] + " [2]" + unique2[2] + " [3]" + unique2[3] + " [4]" + unique[4] + " ");
                    Console.ReadLine();
                }
                else if ((unique[p] != input3) && (p >= 5))
                {
                    Console.WriteLine("This food is not on the order.");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();

            



        }
    }
}
