using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace ConsoleApp_Demo1.FilesUtils
{
    /*The IEnumerable interface is used to iterate a given object in C#. It contains a method called GetEnumerator. 
    The method allows read-only access to the collection and returns the data of the type IEnumerable.*/
    internal class IEnumerableExample : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Employee
    {

        // Declare 4 variables - id, name, 
        // department, and salary
        public int id;
        public int salary;
        public string name;
        public string department;

        // Get the to string method that returns 
        // id, name, department, and salary
        public override string ToString()
        {
            return id + " " + name + " " +
               salary + " " + department;
        }

        // Declare a list variable 
        public List<Employee> emp = new List<Employee>();
        public List<Employee> EmpLists()
        {

            emp.Add(new Employee { id = 201, name = "Druva", salary = 12000, department = "HR" });
            emp.Add(new Employee { id = 202, name = "Deepu", salary = 15000, department = "Development" });
            emp.Add(new Employee { id = 204, name = "Sathwik", salary = 12000, department = "Designing" });
            emp.Add(new Employee { id = 205, name = "Suraj", salary = 15000, department = "Development" });

            return emp;
        }

        // Iterate the Employee by selecting Employee 
        // name starts with D
        // Using IEnumerable interface
        public void excute()
        {
            IEnumerable<Employee> result = EmpLists().Where(x => x.name[0] == 'D');

            // Display employee details
            Console.WriteLine("ID  Name  Salary  Department");
            Console.WriteLine("++++++++++++++++++++++++++++");
            foreach (Employee e in result)
            {
                // Call the to string method
                Console.WriteLine(e.ToString());
            }
        }
    }

}



