using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace SocialApp.Pages_Posts
{
    public class IndexModel : PageModel
    {
        private readonly SocialAppContext _context;

        public IndexModel(SocialAppContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Contents { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PostContents { get; set; }

        public async Task OnGetAsync()
        {
            // using System.Linq;
            var posts = from p in _context.Post
                         select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                posts = posts.Where(s => s.Content.Contains(SearchString));
            }

            Post = await posts.ToListAsync();
        }
    }
}
