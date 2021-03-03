using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApplication.Models
{
    public class Blog
    {
        
        [StringLength(60, ErrorMessage = "You title should not exceed sixty characters.")]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]

        [Display(Name ="Content")]
        public string Body { get; set; }

        public Author Author { get; set; }

        [Editable(false)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

    }
}
