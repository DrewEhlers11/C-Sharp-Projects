using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    public class Employee<T> : Person, IQuittable
    {
        public int Id {get; set;}

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public List<T> EmployeeList { get; set; }

        


        //public static bool operator == (Employee employee, Employee employee2)
        //{
        //    return (employee.Id == employee2.Id);
        //}

        //public static bool operator != (Employee employee, Employee employee2)
        //{
        //    return (employee.Id != employee2.Id);
        //}
    }
}
