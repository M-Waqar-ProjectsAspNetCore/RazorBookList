using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorBookList.Data;
using RazorBookList.Models;

namespace RazorBookList.Pages.Book
{
    public class DeleteModel : PageModel
    {
        private readonly RazorBookList.Data.ApplicationContext _context;

        public DeleteModel(RazorBookList.Data.ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Books Books { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Books = await _context.Book.FirstOrDefaultAsync(m => m.Id == id);

            if (Books == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Books = await _context.Book.FindAsync(id);

            if (Books != null)
            {
                _context.Book.Remove(Books);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./" + nameof(Index));
        }
    }
}
