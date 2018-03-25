using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car_1 = new Car("Name", "lastName", "sms", "Email");
            Console.WriteLine("Car_1: "+car_1.LastName);
            Console.WriteLine("Car_1: "+car_1.Email);
            Console.WriteLine("Car_1: "+car_1.SMS);
            Console.WriteLine("");

            ISMSNotify car_2= new Car("Name", "lastName", "sms", "Email");
            car_2.Name = "Car_2";
            Console.WriteLine("Car_2: " + car_2.LastName);
            Console.WriteLine("Car_2: " + car_2.Name);
            Console.WriteLine("Car_2: " + car_2.SMS);
            Console.WriteLine("");

            IEmailNotify car_3 = new Car("Name", "lastName", "sms", "Email");
            car_3.Name = "Car_3";
            Console.WriteLine("Car_3: " + car_3.LastName);
            Console.WriteLine("Car_3: " + car_3.Name);
            Console.WriteLine("Car_3: " + car_3.Email);

        }
    }
    //********************************************************************************
    public abstract class abstract_1:interface_1
    {
        public string Name { get; set; }

        public void GetName()
        {
            throw new NotImplementedException();
        }

        public abstract void TestAbstract();

        public virtual string GetVirtualStringName()
        {
            return "Name";
        }
    }
    //********************************************************************************
    public class Implemention_1 : interface_1
    {
        public string Name { get; set; }
        public void GetName()
        {
            throw new NotImplementedException();
        }
    }

    //********************************************************************************
    public interface interface_1
    {
        string Name { get; set; }
        void GetName();
    }
    //***********************************************************************************
    public interface IEmailNotify: ILastName
    {
        string Name { get; set; }
        string Email { get; set; }
        void Notify();
    }
    //***********************************************************************************
    public interface ISMSNotify: ILastName
    {
        string Name { get; set; }
        string SMS { get; set; }
        void Notify();
    }
    //***********************************************************************************
    public class Car : ISMSNotify, IEmailNotify
    {
        public Car(string name,string lstName,string sms, string email)
        {
            LastName = lstName;
            SMS = sms;
            Email = email;
        }

        public string Name { get; set; }
        string ISMSNotify.Name
        {
            get;
            set;
        }
        string IEmailNotify.Name
        {
            get;
            set;
        }

        public string Email { get; set; }
        public string SMS { get; set; }

        

        public void  Notify()
        {
        }

        void ISMSNotify.Notify()
        {
            throw new NotImplementedException();
        }

        void IEmailNotify.Notify()
        {
            throw new NotImplementedException();
        }

        public string LastName { get; set; }
    }
    //***********************************************************************************
    public interface ILastName
    {
        string LastName { get; set; }
    }
    //***********************************************************************************

}
