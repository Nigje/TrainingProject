using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe emp=new Employe();
            emp.Level = "Test";
            emp.JobPosition = "Security";
            string resutl = emp.Level;
        }
    }
    //***********************************************************
    public class Human
    {
        public Human()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _level;

        public virtual string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public virtual string Level
        {
            get { return _level; }
            set
            {
                string temp = "";
                _level = value;
            }
        }

        protected virtual string GetName()
        {
            return "";
        }
    }
    //***********************************************************
    public class Employe : Human
    {
        public string JobPosition { get; set; }
        public override string FullName {
            get { return base.FullName + " " + JobPosition; }
        }

        public override string Level {
            get { return base.Level + " " + JobPosition; }
            set
            {
                string temp = "";
                base.Level = value;
            }
        }
    }
}
