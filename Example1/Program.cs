using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";

            Console.WriteLine("This is {0}", th.Name);
            Console.WriteLine("Thread Id: {0}", th.ManagedThreadId);
            Console.WriteLine("Thread State: {0}", th.ThreadState);
            Console.WriteLine("Thread IsAlive ? {0}", th.IsAlive);
            Console.WriteLine("Thread IsBackground ? {0}", th.IsBackground);
            Console.WriteLine("Thread IsThreadPoolThread ? {0}", th.IsThreadPoolThread);

            Console.ReadKey();
        }
    }
}

