using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    public class Method
    {
        public void Method1(int input1)
        {
            int userinput1 = input1 / 2;
            Console.WriteLine(userinput1);
        }

        public void Method1(out int input2)
        {
            input2 = 0;
            int userinput2 = input2 / 2;
            Console.WriteLine(userinput2);
        }
    }
}
