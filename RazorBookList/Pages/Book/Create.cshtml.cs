using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorBookList.Data;
using RazorBookList.Models;

namespace RazorBookList.Pages.Book
{
    public class CreateModel : PageModel
    {
        private readonly RazorBookList.Data.ApplicationContext _context;

        public CreateModel(RazorBookList.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Books Books { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Books);
            await _context.SaveChangesAsync();

            return RedirectToPage(nameof(Index));
        }
    }
}
