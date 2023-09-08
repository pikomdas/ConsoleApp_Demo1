using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Demo1.FilesUtils
{
    class MappingObjects
    {
        Person person = new Person();
        Employee employee = new Employee();

        //Hashtable Hashtable = new Hashtable();
        Dictionary<String, Person> keyValuePairs = new Dictionary<String, Person>();
        private Dictionary<String, Person> mappingPersonAndEmployee()
        {
            Console.WriteLine("Mapping Employee class name with Person Class");
            // Checking both list are emplty or not
            if (person.PersonDetails().Count() > 0 && employee.EmpLists().Count > 0)
            {
                foreach (Employee emp in employee.EmpLists())
                {
                    foreach (Person per in person.PersonDetails())
                    {
                        if (emp.name.Equals(per.Name))
                        {
                            if (!keyValuePairs.ContainsKey(per.Name))
                            {
                                keyValuePairs.Add(emp.name, per);
                            }
                        }
                    }
                }
            }
            return keyValuePairs;   
        }

        public void GetMappedValues()
        {
            mappingPersonAndEmployee();
            //Accessing Dictionary Elements using For Each Loop
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, Person> KVP in keyValuePairs)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }
        }


    }
}
