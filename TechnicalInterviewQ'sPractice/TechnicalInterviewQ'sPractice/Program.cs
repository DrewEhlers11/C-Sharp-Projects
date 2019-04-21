using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterviewQ_sPractice
{
    class Program
    {
        static void Main()
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5 };
            int odd = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 2 == 0)
                    odd += myArray[i];
            }

            Console.WriteLine("Sum:" + odd);
            Console.ReadLine();
        }

        static void SumOfAllNumbers()
        {
            int[] myArray2 = new int[] { 1, 4, 16, 789, 120982, 235702438 };
            int sum = myArray2.Sum();

            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine(sum);
                Console.ReadLine();
            }
        }

        static void ReverseString()
        {
            string Str, reversestring = "";
            int Length;
            Console.Write("Enter a string : ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                reversestring = reversestring + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse String Is {0}", reversestring);
            Console.ReadLine();
        }

        static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }

        static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
