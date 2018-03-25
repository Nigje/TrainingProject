using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child_1=new Child();
            Child child_2=new Child("Test");
            Test test=new Test("TEst");
        }

    }
    //*************************************************************************
    public class VeryChild : Child
    {
        //protected  override void GetPrivateFullName()
        //{
        //    throw new NotImplementedException();
        //}
        public override string GetFullName()
        {
            throw new NotImplementedException();
        }
    }

    //*************************************************************************
    public class Child : Person
    {
        public Child()
        {

        }
        public Child(string Name)
        {

        }

        public override string FullName { get; set; }
        public override string GetFullName()
        {
            throw new NotImplementedException();
        }

        protected sealed override void GetPrivateFullName()
        {
            throw new NotImplementedException();
        }

        public override string GetFullNameVirtual(string Name)
        {
            return base.GetFullNameVirtual(Name)+" ";
        }
    }
    //*************************************************************************
    public abstract class Person
    {
        public Person()
        {
        }
         public Person(string Name)
        {
        }

        public abstract  string FullName { get; set; }
        public abstract string GetFullName();
        //private abstract void GetPrivateFullName() ;
        protected abstract void GetPrivateFullName();

        public string GetFullName(string Name)
        {
            return Name;
        }

        public virtual string GetFullNameVirtual(string Name)
        {
            return Name;
        }
        protected virtual string GetFullNameProtectedVirtual(string Name)
        {
            return Name;
        }

    }
    //*************************************************************************
    public abstract class ATest
    {
        public string Name { get; set; }        
        public ATest()
        {
            Name = "adf";
            Console.WriteLine("Constructor ATest");
        }
    }
    //*************************************************************************
    public class Test : ATest
    {
        public Test(string Name) : base()
        {
            Console.WriteLine("Constructor Test");
        }
    }
}
