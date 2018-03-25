using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constractor
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Person person_1 = new Person();
                Person person_2 = person_1.CreateInstanceOfPersen("Test");
                string name = person_2.Name;
            }
        }

        public class Person
        {
            public Person() : this(null, null)
            {
                //Execute Second
            }

            public Person(string firstName, string lastName)
            {
                //Excute first
            }

            private Person(string Name)
            {
                this.Name = Name;
            }

            public Person CreateInstanceOfPersen(string Name)
            {
                return new Person(Name);
            }

            public string Name { get; set; }
        }
        public class Parent_2
        {
            public Parent_2()
            {
            }

            public Parent_2(string Name)
            {
            }
        }

        public class Child_2 : Parent_2
        {
            public Child_2() 
            {
            }

        }
    }
}
