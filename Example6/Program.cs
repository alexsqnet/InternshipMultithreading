using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Task<int>.Factory.StartNew(() => {
                Console.WriteLine($"t: Task.CurrentId{Task.CurrentId}\tManagedThreadId{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10000);
                var randomNumber = new Random().Next(1, 100);
                return randomNumber;
            });

            var t2 = Task.Factory.StartNew(() => { 
                Console.WriteLine($"t2: Task.CurrentId{Task.CurrentId}\tManagedThreadId{Thread.CurrentThread.ManagedThreadId}"); 
            });

            Console.WriteLine("Random number: {0}", t.Result);
            Console.WriteLine("Main thread");
            
            Console.ReadKey();
        }
    }
}
