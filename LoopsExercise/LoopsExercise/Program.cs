using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopsExercise
{
    class Program
    {
        private static TimerCallback callback;

        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color? You have red, blue, and green to pick from.");
            string color = Convert.ToString(Console.ReadLine());
            bool isGuessed = false;



            do
            {
                switch (color)
                {

                    case "green":
                        Console.WriteLine("You guessed the color green. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;

                    case "red":
                        Console.WriteLine("You guessed the color red. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;

                    case "blue":
                        Console.WriteLine("You guessed the color blue. That is correct!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.Read();

            bool trueOrFalse = true;

            while (trueOrFalse == true)
            {
                switch (color)
                {

                    case "green":
                        Console.WriteLine("You guessed the color green. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;

                    case "red":
                        Console.WriteLine("You guessed the color red. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;

                    case "blue":
                        Console.WriteLine("You guessed the color blue. That is correct!");
                        trueOrFalse = false;
                        break;

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color?");
                        color = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
