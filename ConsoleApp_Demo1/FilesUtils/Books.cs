using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Demo1.FilesUtils
{
    class Books
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        public static List<string> list = new List<string>();
        public List<String> addBooks()
        {
            foreach (var item in cars)
            {
                /*if(list.Count == cars.Length)
                {*/
                    list.Add(item);
                //}
                
               // Console.WriteLine(item);
            }
            
            return list;
        }
    }
}
