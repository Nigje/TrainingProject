using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeElement root =
                new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch

            CompositeElement comp =
                new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement

            PrimitiveElement pe =
                new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes

            root.Display(2);
        }
    }
    //**************************************************************
    public abstract class ComponentAbstract
    {
        protected string _name;

        protected ComponentAbstract(string Name)
        {
            this._name = Name;
        }

        public abstract void Add(ComponentAbstract componentAbstract);
        public abstract void Remove(ComponentAbstract componentAbstract);
        public abstract void Display(int index);
    }
    //************************************************************
    public class PrimitiveElement:ComponentAbstract
    {
        public PrimitiveElement(string Name) : base(Name)
        {
        }

        public override void Add(ComponentAbstract componentAbstract)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Remove(ComponentAbstract componentAbstract)
        {
            Console.WriteLine("Cannot remove to a PrimitiveElement");
        }

        public override void Display(int index)
        {
            Console.WriteLine(
                new String('-', index) + " " + _name);
        }
    }
    //************************************************************
    public  class CompositeElement:ComponentAbstract
    {
        private  List<ComponentAbstract> _list=new List<ComponentAbstract>();
        public CompositeElement(string Name) : base(Name)
        {
        }

        public override void Add(ComponentAbstract componentAbstract)
        {
            _list.Add(componentAbstract);
        }

        public override void Remove(ComponentAbstract componentAbstract)
        {
            _list.Remove(componentAbstract);
        }

        public override void Display(int index)
        {
            Console.WriteLine(new String('-', index) + "+ " + _name);
            foreach (ComponentAbstract componentAbstract in _list)
            {
                componentAbstract.Display(index+2);
            }
        }
    }
}
