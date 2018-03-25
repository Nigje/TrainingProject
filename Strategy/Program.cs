using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorter sorter=new Sorter();
            sorter.Add("Test");
            sorter.SetStrategy(new BubbleSort());
            sorter.Sort();
            sorter.SetStrategy(new Quicksort());
            sorter.Sort();
        }
    }
    //**************************************************************
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
    //**************************************************************
    public class Quicksort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Quick sort");
        }
    }
    //**************************************************************
    public class BubbleSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Bubble sort");
        }
    }
    //**************************************************************
    public class Sorter
    {
        private  List<string> _list;
        private SortStrategy _sortStrategy;

        public Sorter()
        {
            _list = new List<string>();
        }

        public void SetStrategy(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string str)
        {
            _list.Add(str);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);
        }
    }

    //**************************************************************
}
