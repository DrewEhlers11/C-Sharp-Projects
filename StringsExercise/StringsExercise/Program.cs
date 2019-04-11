using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = "Torrential";
            string s1 = "Weather";
            string s2 = " in";
            string s3 = " Wisconsin";
            string s4 = s1 + s2 + s3;



            name = name.ToUpper();



            StringBuilder builder = new StringBuilder();
            Console.WriteLine(s4);
            builder.Append("has been especially fierce this week.");
            builder.AppendLine();

            builder.Append("It all began on Tuesday, when a tornado swept through the St.Croix River Valley.").AppendLine();
            builder.Append("Wednesday evening another tornado dropped down on the suburbs of Milwaukee.").AppendLine();
            builder.Append("Then on Thursday evening, River Falls experienced a " + name + " rain that flooded the streets.").AppendLine();
            builder.Append("Many are wondering what Wisconsin city will be next.").AppendLine();


            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
