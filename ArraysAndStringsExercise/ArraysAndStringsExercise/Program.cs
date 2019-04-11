using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Hello", "my", "name", "is", "Drew" };

            int[] numArray = { 1, 2, 3, 4, 5 };

            List<string> stringList = new List<string>();
            stringList.Add("Some");
            stringList.Add("code");
            stringList.Add("I");
            stringList.Add("have");
            stringList.Add("wrote");



            Console.WriteLine("Please pick a number between 0 and 4.");
            int input1 = Convert.ToInt32(Console.ReadLine());


            if (input1 > 5) Console.WriteLine("This index does not exist.");
            else Console.WriteLine(stringArray[input1]);



            Console.WriteLine("Now, pick another number between 0-4 again.");
            int input2 = Convert.ToInt32(Console.ReadLine());


            if (input2 > 5) Console.WriteLine("This index does not exist.");
            else Console.WriteLine(numArray[input2]);



            Console.WriteLine("And again, pick another number between 0-4.");
            int input3 = Convert.ToInt32(Console.ReadLine());


            if (input3 > 5) Console.WriteLine("This index does not exist.");
            else Console.WriteLine(stringList[input3]);

            Console.ReadLine();
        }
    }
}
