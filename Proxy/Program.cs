using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyMath proxyMath=new ProxyMath();
            Console.WriteLine(proxyMath.Add(1,2));
        }
    }
    //**********************************************************
    public interface IMath
    {
        int Add(int a, int b);
    }
    //**********************************************************
    public class Math:IMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    //**********************************************************
    public class ProxyMath:IMath
    {
        private Math _math;
        public  ProxyMath()
        {
            _math=new Math();
        }

        public int Add(int a, int b)
        {
            return  _math.Add(a, b);
        }
    }
    //**********************************************************
}
