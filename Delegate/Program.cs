using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodPointer methodPointer = AddInt;
            Console.WriteLine(methodPointer(2,3));
            Console.WriteLine(CompareValue(2,3,CompareAsc));
            //Anonymous Method
            MethodPointer Point = delegate(int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(CompareValue(2, 3, delegate(int a, int b) { return a > b; }));

            //Lambda Expression
            MathZarb2 zarb2 = (a) => { return a * 2; };
            MathZarb2 zarb2_2 = a =>  a * 2 ;
            Console.WriteLine("Lambda Expression: "+zarb2_2(2));
            //Generic
            MathString <string, int, int> mathString = (p1, p2) =>
            {
                return (p1 * p2).ToString();

            };
            MathString<string, int, int> mathString_2 = delegate(int p1, int p2)
            {
                return (p1 * p2).ToString();

            };
            Console.WriteLine("Generic: " + mathString_2(2,3));

        }
        public static int AddInt(int a, int b)
        {
            return a + b;
        }

        public static bool CompareAsc(int a, int b)
        {
            return a <= b;
        }

        public static bool ComoareDes(int a, int b)
        {
            return a >= b;
        }

        public static  bool CompareValue(int a, int b, MethodPonterBool pointer)
        {
            return pointer(a, b);
        }

    }
    //*****************************************************
    
    public delegate int MethodPointer(int a, int b);
    //*****************************************************
    public delegate bool MethodPonterBool(int a, int b);
    //*****************************************************
    public delegate int MathZarb2(int a);
    //*****************************************************
    public delegate Tout MathString<Tout, Tp1, Tp2>(Tp1 p1, Tp2 p2);



}
