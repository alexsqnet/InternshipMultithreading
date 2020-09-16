using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static List<User> _users = new List<User>();

        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(()=> {
                AddUser("John");
            });            
            
            Task t2 = Task.Factory.StartNew(()=> {
                AddUser("Mary");
            });            
            
            Task t3 = Task.Factory.StartNew(()=> {
                AddUser("Anna");
            });

            Task.WaitAll(t1, t2, t3);

            DisplayAllUsers();

            Console.ReadLine();
        }

        static void AddUser(string userName) 
        {
            var newuser = new User() { Username = userName };
            //Some logic...
            Thread.Sleep(5000);

            newuser.Id = _users.Count() + 1;

            Console.WriteLine($"TaskId: {Task.CurrentId} ThreadId: {Thread.CurrentThread.ManagedThreadId} adding new user..");
            _users.Add(newuser);
        }

        static void DisplayAllUsers() 
        {
            Console.WriteLine("User list:");

            foreach (var user in _users)
            {
                Console.WriteLine($"Id:{user.Id} Username:{user.Username}");
            }
        }
    }

    class User 
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
