using System.ComponentModel.DataAnnotations;

namespace PracticeQuotes.Api.Models
{
    public class Quote
    {
        public long Id { get; set;}

        [Required]
        public string Content { get; set; }
        [Required]        
        public string Author { get; set; }
    }
}