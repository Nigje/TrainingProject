using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Parent parent_1=new Parent();");
            //Parent parent_1=new Parent();
            Console.WriteLine("\n\nParent parent_2=new Child();");
            Parent parent_2=new Child();
            Console.WriteLine("\n\nChild child=new Child();");
            Child child=new Child();
        }
    }
    //**********************************************************************************
    public class Parent
    {
        static Parent()
        {
            Console.WriteLine("Parent_Static_Constructor");
        }

        public Parent()
        {
            Console.WriteLine("Parent_Normal_Constructor");
        }
    }
    //**********************************************************************************
    public class Child:Parent
    {
        static Child()
        {
            Console.WriteLine("Child_Static_Constructor");
        }

        public Child()
        {
            Console.WriteLine("Child_Normal_Constructor");
        }
    }
    //**********************************************************************************
    public static class StaticParent
    {
        public static string Parentproperty { get; set; }
        public static string StaticProperty { get; set; }

        static StaticParent()
        {
        }
    }
    //**********************************************************************************
    public static class StaticChild
    {
        public static string Childproperty { get; set; }
        public static string StaticProperty { get; set; }
        static StaticChild()
        {
        }
    }
    //**********************************************************************************
    public class Test
    {
    }
}
