using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            var result = a.GetPow(3);
        }
    }

    public static class Global
    {
        public static int GetPow(this int number, int pow)
        {
            int result = 1;
            for (int counter = 0; counter < pow; counter++)
                result = result * number;
            return result;
        }
    }
  
}
