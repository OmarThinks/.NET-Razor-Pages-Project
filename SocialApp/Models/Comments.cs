using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace RazorPagesMovie.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

	    public int PostId { get; set; }
	    public Post Post { get; set; }
    }
}
