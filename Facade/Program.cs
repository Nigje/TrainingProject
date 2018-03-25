using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFacade carFacade=new CarFacade();
            carFacade.AssembleCar();
        }
    }
    //**************************************************************
    public class Engine
    {
        public void AssembleEngine()
        {
            Console.WriteLine("Engine assembled");
        }
    }

    //**************************************************************
    public class Body
    {
        public void AssembleEngine()
        {
            Console.WriteLine("Engine assembled");
        }
    }
    //**************************************************************
    public class CarFacade
    {
        private Engine _engine;
        private Body _body;

        public CarFacade()
        {
            _engine=new Engine();
            _body=new Body();
        }
        public void AssembleCar()
        {
            _engine.AssembleEngine();
            _body.AssembleEngine();
            Console.WriteLine("Car assembled");
        }
    }

    //**************************************************************
}
