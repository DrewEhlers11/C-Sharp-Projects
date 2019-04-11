using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();

            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Smith", Id = 1234 };
            Employee employee2 = new Employee() { FirstName = "Joe", LastName = "John", Id = 5894 };
            Employee employee3 = new Employee() { FirstName = "Sally", LastName = "Wally", Id = 1852 };
            Employee employee4 = new Employee() { FirstName = "Betsy", LastName = "Betsy", Id = 2265 };
            Employee employee5 = new Employee() { FirstName = "Danny", LastName = "Fanny", Id = 0024 };
            Employee employee6 = new Employee() { FirstName = "Josh", LastName = "Johnson", Id = 7432 };
            Employee employee7 = new Employee() { FirstName = "Gary", LastName = "Larry", Id = 0101 };
            Employee employee8 = new Employee() { FirstName = "Barry", LastName = "Lampkin", Id = 9102 };
            Employee employee9 = new Employee() { FirstName = "Jared", LastName = "Snell", Id = 1325 };
            Employee employee10 = new Employee() { FirstName = "Paul", LastName = "Small", Id = 1935 };

            EmployeeList.Add(employee1);



            List<Employee> EmployeeList2 = new List<Employee>();

            foreach (Employee employee in EmployeeList2)
            {
                if (employee.FirstName == "Joe")
                {
                    EmployeeList2.Add(employee);
                }
            }



            List<Employee> EmployeeList3 = new List<Employee>();

            var joe = EmployeeList3.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in EmployeeList3)
            {
                EmployeeList3.Add(employee);
            }



            List<Employee> EmployeeList4 = new List<Employee>();

            var identity = EmployeeList4.Where(i => i.Id > 5).ToList();

            foreach (Employee employee in EmployeeList4)
            {
                EmployeeList4.Add(employee);
            }
        }
    }
}
