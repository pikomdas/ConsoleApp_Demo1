using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Demo1.FilesUtils.Interfaces
{
    interface IPerson<T>
    {
        public List<T> PersonDetails();
    }

    interface IEmployee<T>
    {
        public List<T> EmpLists();

        public void excute();
    }
}
