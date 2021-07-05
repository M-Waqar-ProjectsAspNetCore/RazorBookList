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
    public class IndexModel : PageModel
    {
        private readonly RazorBookList.Data.ApplicationContext _context;

        public IndexModel(RazorBookList.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Books> Books { get;set; }

        public async Task OnGetAsync()
        {
            Books = await _context.Book.ToListAsync();
        }
    }
}
