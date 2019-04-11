using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number Amount = new Number();
            Number Amount2 = Amount;
            Amount.Amount = 5;

            Console.WriteLine(Amount.Amount);
            Console.ReadLine();
        }
    }
}
