using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_Demo1.FilesUtils
{
    class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public Person(string ssn, string name, string addr, int age)
        {
            SSN = ssn;
            Name = name;
            Address = addr;
            Age = age;
        }

        public Person()
        {
            Console.WriteLine("Default Contructor called");
        }

        public override string ToString()
        {
            return SSN + " " + Name + " " + Address + " " + Age +"\n";
        }

        // Creating List to store objects of Person
        List<Person> listPersonsInCity = new List<Person>();
        public List<Person> PersonDetails()
        {
            listPersonsInCity.Add(new Person("203456876", "Druva", "12 Main Street, Newyork, NY", 15));
            listPersonsInCity.Add(new Person("203456877", "Deepu", "13 Main Ct, Newyork, NY", 25));
            listPersonsInCity.Add(new Person("203456878", "Suraj", "14 Main Street, Newyork, NY", 35));
            listPersonsInCity.Add(new Person("203456880", "Sathwik", "12 Main Street, Newyork, NY", 45));
            listPersonsInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton, OH", 55));
            listPersonsInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456882", "Winston", "1208 Alex St, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore, NY", 85));
            listPersonsInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore, NY", 95));

            return listPersonsInCity;
        }

        public void filterAge()
        {
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("Retrieving Top 2 aged persons from the list who are older than 60 years\n");
            foreach (Person person in PersonDetails().FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }

        public void findElementBetweenOfRange()
        {
            Console.WriteLine("\nChecking whether any person is teen-ager or not...");
            if (PersonDetails().Any(e => (e.Age >= 13 && e.Age <= 19)))
            {
                Console.WriteLine("Yes, we have some teen-agers in the list");
            }
        }

        public void checkingAgeLessOrGrater()
        {
            Console.WriteLine("\nCheking whether all the persons are older than 10 years or not...");
            if (PersonDetails().All(e => (e.Age > 10)))
            {
                Console.WriteLine("Yes, all the persons older than 10 years");
            }

            Console.WriteLine("\nSkipping every person whose age is less than 60 years...");
            foreach (Person pers in PersonDetails().SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine("Name : " + pers.Name + " \t\tAge: " + pers.Age);
            }
        }

        public void FindIndex()
        {
            Console.WriteLine("\nChecking the index position of a person having name 'Smith' ...");
            int indexForSmith = PersonDetails().FindIndex(e => e.Name == "Smith");
            Console.WriteLine("In the list, The index position of a person having name 'Smith' is : " + indexForSmith);
        }

        public void FindGreatest()
        {
            Console.WriteLine("\nGetting the name of the most aged person in the list ...");
            Person p = PersonDetails().First(m => m.Age == (PersonDetails().Max(e => e.Age)));
            Console.WriteLine("The most aged person in our list is: " + p.Name + " whose age is: " + p.Age);
        }

        public void PersonHavingSSN()
        {
            Console.WriteLine("\nFinding the person whose SSN = 203456876 in the list");
            Person oPerson = PersonDetails().Find(e => e.SSN == "203456876");
            Console.WriteLine("The person having SSN '203456876' is : " + oPerson.Name + " \t\tAge: " + oPerson.Age);
        }

        public void shortingArrays()
        {
            Console.WriteLine("\n Sorting the person in the list ...");

            //Array.Sort(PersonDetails().ToArray());
            List<Person> ll = PersonDetails();
            // Sort By Age
            Console.WriteLine("Sorting with single variable..........");
            ll.Sort((x, y) => x.Age.CompareTo(y.Age));

            foreach (var item in ll)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            // Sort of mutiple parameter
            Console.WriteLine("Sorting with mutiple variables..........");
            ll = ll.OrderBy(p => p.SSN).ThenByDescending(p => p.Name).ToList();
            foreach (var item in ll)
            {
                Console.WriteLine(item.SSN + " " + item.Age + " " + item.Name);
            }
        }



    }

}
