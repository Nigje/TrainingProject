using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessModifier_ClassLibrary;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child=new Child();
            var s=child.GetName();
            var c1 = child.GetPublicVirtualGetName();
            var c2 = child.ForOverride();
            child.Method_TestNewMethod();

            Parent p=new Child();
            //اگر اور رایت نکرده باشیم دوپلیکیت متد میشه که با توجه به نوعش صدا می کنه
            var y=p.GetName();
            var y1 = p.GetPublicVirtualGetName();
            //اگر اور کرده باشیم به نوع کاری نداره
            var y2 = p.ForOverride();
            p.Method_TestNewMethod();



            //-----------------------------
            ChildGrandParent childGrandParent=new ChildGrandParent();            
            //-----------------------------

        }
    }
    //******************************************************************
    public class Parent
    {
        public  Parent()
        {
        }

        public string PublicString = "afd";
        protected internal string InternalName = "af";
        private string smale = "Test";
        protected string Name { get; set; }
        protected string GetParentName()
        {
            return smale;
        }
        public string GetName()
        {
            Console.WriteLine("Parent_GetName");
            return "Parent.GetName";
        }

        protected virtual string GetprotectedVirtualGetName()
        {
            return "ParentGetprotectedVirtualGetName";
        }
        protected virtual string ForTest_VeryChild()
        {
            return "Parent_ForTest_VeryChild";
        }
        public virtual string GetPublicVirtualGetName()
        {
            Console.WriteLine("Parent_GetPublicVirtualGetName");
            return "Parent_GetPublicVirtualGetName";
        }
        public virtual string ForOverride()
        {
            Console.WriteLine("parent_ForOverride");
            return "parent_ForOverride";
        }

        public void Method_TestNewMethod()
        {
            Console.WriteLine("Parent_TestNewMethod");
        }
    }
    //******************************************************************
    public class Child : Parent
    {
        public Child()
        {
            Name = "Salam";
        }
        protected override string GetprotectedVirtualGetName()
        {
            Console.WriteLine("Child_GetprotectedVirtualGetName");
            return "ChildGetprotectedVirtualGetName";
        }
        public virtual string GetPublicVirtualGetName()
        {
            Console.WriteLine("Child_GetPublicVirtualGetName");
            return "Child_GetPublicVirtualGetName";
        }
        public override string ForOverride()
        {
            Console.WriteLine("Child_ForOverride");
            return "Child_ForOverride";
        }
        public string GetName()
        {
            return GetParentName();
        }
        protected override string ForTest_VeryChild()
        {
            return "Parent_ForTest_VeryChild";
        }
        public new void Method_TestNewMethod()
        {
            Console.WriteLine("Child_New_Method_TestNewMethod");
        }
    }
    //******************************************************************
    public class VeryChild : Child
    {
        public VeryChild()
        {
            Name = "VeryChild";
            var c=ForTest_VeryChild();
            string f = c + "asfd";
        }

        protected override string ForTest_VeryChild()
        {
            return base.ForTest_VeryChild();
        }
        public override string GetPublicVirtualGetName()
        {
            return "VeryChild_GetPublicVirtualGetName";
        }
    }
    //******************************************************************
    public  class ChildGrandParent:GrandParent
    {
        private class Temp
        {
            private string a = "";
        }
        public ChildGrandParent()
        {
            Temp temp=new Temp();
        }
    }
}

