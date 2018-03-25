using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> Name = GetName();
            while (Name.IsCompleted!=true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Task is runing... !");
            }
        }

        static async Task<string> GetName()
        {
            string Name = await DoWork();
            return Name;
        }

        private static Task<string> DoWork()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                Console.WriteLine("Task finish... !");
                return "Done.";
            });
        }
    }
}
