using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_RenfrenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRefrenceType testRefrenceType = new TestRefrenceType("First");
            TestRefrenceType SecondTestRefrenceType = new TestRefrenceType("Second");
            testRefrenceType.Name = "First Vaue";
            SecondTestRefrenceType = testRefrenceType;
            TestRefrenceTypeEdit(SecondTestRefrenceType);
            Console.WriteLine("First: "+testRefrenceType.Name);
            Console.WriteLine("Second: "+SecondTestRefrenceType.Name);
        }
        //**************************************************************************************
        public static void TestRefrenceTypeEdit(TestRefrenceType testRefrenceType)
        {
            testRefrenceType.Name = "Second Value";
            TestRefrenceType temp = new TestRefrenceType("Inner Func _ Third");
            temp = testRefrenceType;
            temp.Name = "Thrid Value";
            TestRefrenceType fourthTestRefrenceType=new TestRefrenceType("Fourth");
            fourthTestRefrenceType.Name = "Fourth Value";
        }
        //**************************************************************************************
        public class TestRefrenceType
        {
            public TestRefrenceType(string state)
            {
                _state = state;
                Console.WriteLine("Constructor: " + _state);
            }

            ~TestRefrenceType()
            {
                Console.WriteLine("Destructor " + _state);
            }
            public string Name { get; set; }
            private string _state { get; set; }
        }
        //**************************************************************************************
    }
}
