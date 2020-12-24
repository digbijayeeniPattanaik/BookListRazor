using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class UpsertModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public UpsertModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null) return Page(); //Create

            Book = await _dbContext.Books.FindAsync(id); //Update
            if (Book == null)
                return NotFound();
            return Page();
        }

        public async Task<ActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Book.Id == 0)
                {
                    await _dbContext.Books.AddAsync(Book);
                }
                else
                {
                    var bookDb = await _dbContext.Books.FindAsync(Book.Id);
                    bookDb.Name = Book.Name;
                    bookDb.Author = Book.Author;
                    bookDb.ISBN = Book.ISBN;
                    _dbContext.Books.Update(bookDb);
                }
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