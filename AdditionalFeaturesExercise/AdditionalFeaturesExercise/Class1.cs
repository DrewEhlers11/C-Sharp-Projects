using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesExercise
{
    public class Class1
    {
        public Class1(string name) : this(name, 0){ }
        public Class1(string name, int number)
        {
            Person = name;
            Total = number;
        }
        public string Person { get; set; }
        public int Total { get; set; }
        
            

    }
}
