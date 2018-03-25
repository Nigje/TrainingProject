using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new Iterator();
            foreach (var VARIABLE in collection)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
    //****************************************************************
    public class Iterator : IEnumerable
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public IEnumerator GetEnumerator()
        {
            foreach (string month in months)
            {
                yield return month;
            }
        }
    }
}
