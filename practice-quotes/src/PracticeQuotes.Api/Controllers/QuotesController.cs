using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeQuotes.Api.Data;
using PracticeQuotes.Api.Models;

namespace PracticeQuotes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private readonly PracticeQuotesContext _context;

        public QuotesController(PracticeQuotesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Quote>> GetAll() =>
            _context.Quotes.ToList();

        // GET by ID action
        [HttpGet("{id}")]
        public async Task<ActionResult<Quote>> GetById(long id)
        {
            var quote = await _context.Quotes.FindAsync(id);
            if (quote == null)
            {
                return NotFound();
            }

            return quote;
        }

        // POST action
        [HttpPost]
        public async Task<ActionResult<Quote>> Create(Quote quote)
        {
            _context.Quotes.Add(quote);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = quote.Id }, quote);
        }

        // PUT action

        // DELETE action
    }
}