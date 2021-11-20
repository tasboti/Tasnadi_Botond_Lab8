using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tasnadi_Botond_Lab8.Data;
using Tasnadi_Botond_Lab8.Models;

namespace Tasnadi_Botond_Lab8.Pages.BookCategories
{
    public class IndexModel : PageModel
    {
        private readonly Tasnadi_Botond_Lab8.Data.Tasnadi_Botond_Lab8Context _context;

        public IndexModel(Tasnadi_Botond_Lab8.Data.Tasnadi_Botond_Lab8Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; }

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
