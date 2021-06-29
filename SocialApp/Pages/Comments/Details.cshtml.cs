using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using SocialApp.Data;

namespace SocialApp.Pages_comments
{
    public class DetailsModel : PageModel
    {
        private readonly SocialApp.Data.ApplicationDbContext _context;

        public DetailsModel(SocialApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Comment Comment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Comment = await _context.Comment
                .Include(c => c.Post).FirstOrDefaultAsync(m => m.ID == id);

            if (Comment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
