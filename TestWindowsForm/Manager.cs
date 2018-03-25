using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWindowsForm
{
    public class Manager
    {
        private readonly  ITemp _temp;

        public  Manager()
        {

        }

        public  Manager(ITemp temp)
        {
            _temp = temp;
        }

        public int add(int a, int b)
        {
            return _temp.add(a, b);
        }
    }
}
