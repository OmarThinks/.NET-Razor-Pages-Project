using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

    public class SocialAppContext : DbContext
    {
        public SocialAppContext (DbContextOptions<SocialAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Post> Post { get; set; }
    }
