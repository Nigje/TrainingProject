using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonReposotory reposotory=new PersonReposotory();
            reposotory.AddPerson(new Person(){LastName = "Add"});
            reposotory.RemovePerson(new Person(){LastName = "Remove"});
            reposotory.OnAdd += Loger;
            reposotory.AddPerson(new Person() { LastName = "Add" });
        }

        public static  void Loger(Person person)
        {
            Console.WriteLine("Loger_ExternalMethod: "+ person.FirstName + "  " + person.LastName);
        }
    }
    
    //*****************************************************************
    public delegate void OnAddOrRemove(Person person);
    //*****************************************************************
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //*****************************************************************
    public class PersonReposotory
    {
        public event OnAddOrRemove OnAdd;
        public event OnAddOrRemove OnRemove;

        public  PersonReposotory()
        {
            OnAdd += Log;
            OnRemove += Log;
        }

        public void AddPerson(Person person)
        {
            if (OnAdd!=null)
            {
                OnAdd(person);
            }
        }

        public void RemovePerson(Person person)
        {
            if (OnRemove != null)
            {
                OnRemove.Invoke(person);
            }
        }

        private void Log(Person person)
        {
            Console.WriteLine("FullName: " + person.FirstName + "  " + person.LastName);
        }
    }
    //*****************************************************************
    //*****************************************************************
}