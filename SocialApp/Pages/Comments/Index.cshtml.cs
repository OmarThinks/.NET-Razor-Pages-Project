using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using SocialApp.Data;

namespace SocialApp.Pages_comments
{
    public class IndexModel : PageModel
    {
        private readonly SocialApp.Data.ApplicationDbContext _context;

        public IndexModel(SocialApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchPostId { get; set; }
        public SelectList PostIds { get; set; }
        [BindProperty(SupportsGet = true)]
        public string post_id { get; set; }



        public async Task OnGetAsync()
        {

            /*var movies = from m in _context.Movie
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }            


            Comment = await _context.Comment
                .Include(c => c.Post).ToListAsync();
            */

            var comments = from c in _context.Comment
             select c;
            if (!string.IsNullOrEmpty(post_id))
            {
                int PostIdInt = Int32.Parse(post_id);

                comments = comments.Where(s => s.PostId.Equals(PostIdInt));
            }

            Comment = await comments.ToListAsync();





        }
    }
}
