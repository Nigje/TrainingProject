using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    

    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Test test=new Test();
            //تو اورلود ها اولویت با Params است.
            var i = Average(a, test);
            var ii = Average(2, 3,4);
            var iii = Average(new int [] {1,2,3});

            int[] intarray = new[] {1, 2, 3};
            var iiii = AverageTest(intarray);

            //-------------------------------------------------------
             a = 1;
            int b = 1;
            int c = 1;
            int d = 1;
            int e = 1;
            var iiiii 
                = TestRefOut(a, ref b,out d, ref c, out e,a);

            string inputString = "TEst";
            var resutl = ChangeString(inputString);





        }

        //*********************************************************
        public static string ChangeString(string Name)
        {
            Name += "!!!!!";
            return Name;
        }

        //*********************************************************
        public static int TestRefOut(int a, ref int b,  out int d, ref int c, out int e,int h)
        {
            a = -1;

            b = -1;
            c = -1;
            d = -1;
            e = -1;
            h = -1;
            return 1;
        }

        //*********************************************************
        public static int AverageTest(int[] numbers)
        {
            numbers[0] = -1;
            return 1;
        }
        //*********************************************************
        public static int Average( int[] numbers)
        {
            numbers[0] = -1;
            return 1;
        }
        //*********************************************************
        public static int Average(int a,int b,int c)
        {
          
            return 1;
        }
        //*********************************************************
        public static int Average(params object[] p)
        {
            var a1 = p[0];
            var a2 = p[1];
            return 1;
        }
        //*********************************************************
       
        //*********************************************************
    }

    //*********************************************************
    public class Test
    {
        public Test()
        {
            
        }
    }

}
