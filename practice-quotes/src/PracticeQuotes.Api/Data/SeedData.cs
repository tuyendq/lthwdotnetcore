using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PracticeQuotes.Api.Models;

namespace PracticeQuotes.Api.Data
{
    public static class SeedData
    {
        public static void Initialize(PracticeQuotesContext context)
        {
            if (!context.Quotes.Any())
            {
                context.Quotes.AddRange(
                    new Quote
                    {
                        Content = "Everything is practice.",
                        Author = "Pele"
                    },
                    new Quote
                    {
                        Content = "You are what you practice most.",
                        Author = "To check author"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}