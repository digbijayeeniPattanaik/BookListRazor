using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public IEnumerable<Book> Books { get; set; }
        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task OnGet()
        {
            Books = await _dbContext.Books.ToListAsync();
        }

    }
}