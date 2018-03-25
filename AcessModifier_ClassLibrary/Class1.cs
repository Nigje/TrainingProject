using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifier_ClassLibrary
{
    public class GrandParent
    {
        protected string FirstName { get; set; }
        protected internal string LastName { get; set; }
        private string _name;
        public string Name {
           get { return _name; }
           private set { _name = value; }
    }

        public void GetName()
        {
            Name = "";
        }
    }
}
