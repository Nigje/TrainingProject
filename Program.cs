using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace TestEF
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindsorContainer container = new WindsorContainer();

            // Register the CompositionRoot type with the container
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());
            

            // Resolve an object of type ICompositionRoot (ask the container for an instance)
            // This is analagous to calling new() in a non-IoC application.
            var root = container.Resolve<ICompositionRoot>();

            root.LogMessage("teset");
            // Wait for user input so they can check the program's output.
            Console.ReadLine();
        }
        //**********************************************************************************************
        public class CompositionRoot : ICompositionRoot
        {
            private readonly IConsoleWriter _consoleWriter;

            public  CompositionRoot(IConsoleWriter consoleWriter)
            {
                _consoleWriter = consoleWriter;
                CWriter();
            }

            public void CWriter()
            {
                _consoleWriter.LogConsoleWriter();
            }

            // We will do fancier stuff here in just a bit...
            public void LogMessage(string message)
            {
                Console.WriteLine(message);
            }
        }
        //**********************************************************************************************
        public interface ICompositionRoot
        {
            void LogMessage(string message);
        }
        //**********************************************************************************************
        public interface IConsoleWriter
        {
            void LogConsoleWriter();
        }
        //**********************************************************************************************
        public class ConsoleWriter:IConsoleWriter
        {
            public void LogConsoleWriter()
            {
                Console.WriteLine("I am console Writer");
            }
        }
        //**********************************************************************************************



    }

    
}
