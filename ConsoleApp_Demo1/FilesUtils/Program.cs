using System;
using ConsoleApp_Demo1.FilesUtils;

namespace ConsoleApp_Demo1.FilesUtils
{
    class Demo 
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Staring collections.............");

            /*Books bj=new Books();
            bj.addBooks().Add("Bulls");
            bj.addBooks().Add("OX");
            foreach(var iteam in bj.addBooks())
            {
                Console.WriteLine(iteam);
            }*/
            /*Person person = new Person();
            person.shortingArrays();*/

            // HashSetExmpl hs = new HashSetExmpl();

            /*Employee employee = new Employee();
            employee.excute();*/

            new MappingObjects().GetMappedValues();

            Console.ReadLine();
        }
    }
}