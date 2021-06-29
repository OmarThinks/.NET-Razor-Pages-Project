using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RazorPagesMovie.Models;
using System.Collections.Generic;
using System.Linq;


namespace RazorPagesMovie.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }

    	//[InverseProperty("Post")]
    	public List<Comment> Comments { get; set; }
    }
}


/*

dotnet-aspnet-codegenerator razorpage -m Post -dc SocialApp.Data.ApplicationDbContext -udl -outDir Pages/posts --referenceScriptLibraries -sqlite


*/

