using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //string filename = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse");

            //Console.WriteLine(sb);
            //Console.ReadLine();

            string weather = "Weather";
            string wednesday = "Wednesday";
            string name = "Torrential";

          

            name = name.ToUpper(); 


            
            StringBuilder builder = new StringBuilder();
            builder.Append("" + weather + " in Wisconsin has been especially fierce this week.");
            builder.AppendLine();

            builder.Append("It all began on Tuesday, when a tornado swept through the St.Croix River Valley.").AppendLine();
            builder.Append("" + wednesday + " evening another tornado dropped down on the suburbs of Milwaukee.").AppendLine();
            builder.Append("Then on Thursday evening, River Falls experienced a " + name + " rain that flooded the streets.").AppendLine();
            builder.Append("Many are wondering what Wisconsin city will be next.").AppendLine();


            Console.WriteLine(builder);
            Console.ReadLine();

        }
    }
}
