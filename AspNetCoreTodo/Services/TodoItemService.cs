using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Data;

namespace AspNetCoreTodo.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ApplicationDbContext _context;

        public TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync()
        {
            //throw new System.NotImplementedException();
            return await _context.Items
                .Where(x => x.IsDone == false)
                .ToArrayAsync();
        }
    }
}