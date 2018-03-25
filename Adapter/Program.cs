using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //*********************************************
    public class Employee
    {
        public static void EmployeeList(List<string> empNameList)
        {
            foreach (string s in empNameList)
            {
                Console.WriteLine(s);
            }
        }
    }
    //***********************************************
    interface IEmployee
    {
        void PrintEmployeeList(List<string> stringList);
    }
    //***********************************************
    public class AdapterEmployee:IEmployee
    {
        public void PrintEmployeeList(List<string> stringList)
        {
            Employee.EmployeeList(stringList);
        }
    }
    //***********************************************
    //***********************************************
    //***********************************************
}
