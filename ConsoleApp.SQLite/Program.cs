using System;

namespace ConsoleApp.SQLite
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Getting Started with EF Core on .NET Core Console App with a New database!");

            using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet"});

                db.Blogs.Add(new Blog { Url = "http://www.practicehabits.net" });

                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in databse:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0} ", blog.Url);
                }
            }

        }
    }
}
