using System;
using System.Linq;

using var db = new BloggingContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new blog");
db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
db.SaveChanges();

// Read
Console.WriteLine("Querying for a blog");
var blog = db.Blogs
    .OrderBy(b => b.BlogId)
    .First();

// Update
Console.WriteLine("Updating the blog and adding a post");
blog.Url = "https://devblogs.microsoft.com/dotnet";
blog.Posts.Add(
    new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
db.SaveChanges();

// Update 2
Console.WriteLine("Updating the blog and adding a post");
blog.Url = "https://devblogs.microsoft.com/dotnet2";
blog.Posts.Add(
    new Post { Title = "Post #2", Content = "Content of post #2" });
db.SaveChanges();

Console.WriteLine("Query a post");
var post = db.Posts
    .OrderBy(p => p.PostId)
    .First();
Console.WriteLine($">>> Post title: {post.Title}.");
Console.WriteLine($">>> Post content: {post.Content}.");

Console.WriteLine("Query a post");
var post2 = db.Posts
    .OrderBy(p => p.PostId)
    .Last();
Console.WriteLine($">>> Post title: {post2.Title}.");
Console.WriteLine($">>> Post content: {post2.Content}.");

// Delete
Console.WriteLine("Delete the blog");
db.Remove(blog);
db.SaveChanges();