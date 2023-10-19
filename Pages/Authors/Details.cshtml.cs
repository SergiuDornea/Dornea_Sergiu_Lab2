using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dornea_Sergiu_Lab2.Data;
using Dornea_Sergiu_Lab2.Models;

namespace Dornea_Sergiu_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Dornea_Sergiu_Lab2.Data.Dornea_Sergiu_Lab2Context _context;

        public DetailsModel(Dornea_Sergiu_Lab2.Data.Dornea_Sergiu_Lab2Context context)
        {
            _context = context;
        }

      public Author Author { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
