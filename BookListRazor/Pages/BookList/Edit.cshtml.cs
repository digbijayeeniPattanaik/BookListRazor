using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace BookListRazor.Pages.BookList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
            
        public EditModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int? id)
        {
            Book = await _dbContext.Books.FindAsync(id);
        }

        public async Task<ActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var bookDb = await _dbContext.Books.FindAsync(Book.Id);
                bookDb.Name = Book.Name;
                bookDb.Author = Book.Author;
                bookDb.ISBN = Book.ISBN;
                _dbContext.Books.Update(bookDb);
                await _dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}