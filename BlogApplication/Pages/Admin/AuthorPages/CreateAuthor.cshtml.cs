using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BlogApplication.Models;

namespace BlogApplication.Pages.Admin.AuthorPages
{
    public class CreateAuthorModel : PageModel
    {
        [FromForm]
        public Author Author { get; set; } = new Author();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            
        }

    }
}
