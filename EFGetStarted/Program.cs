// See https://aka.ms/new-console-template for more information
using EFGetStarted.Data;
using EFGetStarted.Models;
Console.WriteLine("Hello, World!");


var context = new EFGetStartedContext();

Product squeakyBone = new Product()
{
  Name = "Squeaky Dog Bone",
  Price = 4.99M
};

context.Add(squeakyBone);
context.SaveChanges();
