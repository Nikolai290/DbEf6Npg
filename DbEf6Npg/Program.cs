using System;
using System.Linq;

namespace DbEf6Npg
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new UserContext())
            {
                var user1 = new User("Tom", 31);
                var user2 = new User("Bob", 26);

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                
                Console.WriteLine("Users have been added.");

                var users = db.Users.ToList();
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Id}. {user.Name} - {user.Age}");
                }
                Console.WriteLine("Users have been showed.");

                Console.ReadKey();
            }
        }
    }
}