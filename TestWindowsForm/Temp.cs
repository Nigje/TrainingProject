using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Temp:ITemp
    {
        public int a { get; set; }
        public int add(int a, int b)
        {
            return a + b;
        }
    }
