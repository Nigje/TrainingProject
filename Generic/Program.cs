using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericType_1<GlobalClass> genericType_1=new GenericType_1<GlobalClass>();
            GenenricType_2<GlobalClass> genericType_2=new GenenricType_2<GlobalClass>();
        }

        static TOut DoSomting<TOut, Par1, Par2>(Par1 p1, Par2 p2)
        {
            return default(TOut);
        }
        static TOut DoSomting<TOut, Par1, Par2>(TOut t1,Par1 p1, Par2 p2)
        {
            return t1;
        }
        
    }
    //********************************************************************************************
    public class TestClass
    {
        public TestClass TestClassName { get; set; }
    }
    //********************************************************************************************
    public interface IInterface_1
    {
        string IInterface_1Name { get; set; }
        string GetName_IInterface_1();
    }
    //********************************************************************************************
    public interface IInterface_2
    {
        string IInterface_2Name { get; set; }
    }
    //********************************************************************************************
    public interface IAbstractClass
    {
         string IAbstractClassName { get; set; }
    }
    //********************************************************************************************
    public abstract class AbstractClass:IAbstractClass
    {
        public string IAbstractClassName { get; set; }
        public string AbstractClassName { get; set; }
    }

    //********************************************************************************************
    public class GlobalClass :  AbstractClass, IInterface_1, IInterface_2
    {
        public string GlobalClassName { get; set; }

        public string GetName_GlobalClas()
        {
            return "GetName_GlobalClas";
        }

        public string IInterface_1Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string GetName_IInterface_1()
        {
            throw new NotImplementedException();
        }

        public string IInterface_2Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }

    //********************************************************************************************
    public class GenericType_1<T> where T : GlobalClass,IAbstractClass,IInterface_1
    {
        public GenericType_1()
        {
           
        }

        public T Property { get; set; }
    }
    //********************************************************************************************
    public class GenenricType_2<T> where T : IInterface_1
    {
        public  GenenricType_2()
        {
            
        }

        public T Peroperty { get; set; }
    }
    //********************************************************************************************
    public interface IDispose
    {
        double CalcualteTax();
    }

    //********************************************************************************************
    public class Product : IDispose
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual double CalcualteTax()
        {
            return 0;
        }
    }

    public class GenericType_3_Virtual<T> where T : Product
    {
        public double CalcualtePricae(Product product)
        {
            return product.Price;
        }
        public string CalcualtePricae(GlobalClass globalClass)
        {
            return globalClass.GetName_GlobalClas();
        }
    }
    //********************************************************************************************
    //********************************************************************************************

}
