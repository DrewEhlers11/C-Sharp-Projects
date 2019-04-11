using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    public class Method
    {
        public int Number(int input1)
        {
            int userinput1 = input1 + 5;
            return userinput1;
        }

        public double Number2(double input2)
        {
            double userinput2 = Convert.ToDouble(input2 - 0.5);
            return userinput2;
        }

        public int StringMethod(string input3)
        {
            int userinput3 = Convert.ToInt32(input3);
            userinput3 = userinput3 + 5;
            return userinput3;
        }
    }
}
