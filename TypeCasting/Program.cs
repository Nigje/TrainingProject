using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child=new Child() {Id=1,Name="FullName"};


            Parent parent = child;
            Console.WriteLine(parent.Id);

            Child child2 = (Child) parent;
            Console.WriteLine(child2.Id);
            Console.WriteLine(child2.Name);

        }
    }
    //**************************************************************
    public class Parent
    {
        public int Id { get; set; }
    }
    //**************************************************************
    public class Child : Parent
    {
        public string Name { get; set; }
    }
    //**************************************************************
}
