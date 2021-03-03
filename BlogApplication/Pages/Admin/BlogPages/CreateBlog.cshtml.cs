using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BlogApplication.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogApplication.Pages.Admin.BlogPages
{
    public class CreateBlogModel : PageModel
    {
        [FromForm]
        public Blog Blog { get; set; } = new Blog();

        private List<Author> Authors = new List<Author>();

        public IEnumerable<SelectListItem> AuthorList { get;set; }

        public CreateBlogModel()
        {
            Author prashant = new Author()
            {
                FirstName = "Prashant",
                LastName = "Dahal",
                Birthday = new DateTime(1996, 10, 20),
                EmailAddress = "prashantdah41@gmail.com",
                WebAddress = "prashantdahal.com.np",
                PhoneNumber = "2498852150",
                Country = "Nepal",
                Province = "Bagmati",
                PostalCode = "44600"
            };
            Author prakriti = new Author()
            {
                FirstName = "Prakriti",
                LastName = "Dahal",
                Birthday = new DateTime(1996, 10, 20),
                EmailAddress = "mynameisprakritidahal@gmail.com",
                WebAddress = "prakritidahal.com.np",
                PhoneNumber = "9843456287",
                Country = "Nepal",
                Province = "Bagmati",
                PostalCode = "44600"
            };
            Author rikesh = new Author()
            {
                FirstName = "Rikesh",
                LastName = "Awale",
                Birthday = new DateTime(1996, 10, 20),
                EmailAddress = "awalerikesh@gmail.com",
                WebAddress = "rikeshawale.com",
                PhoneNumber = "77777777",
                Country = "Germany",
                Province = "Munich",
                PostalCode = "80331"
            };
            Authors.Add(prakriti);
            Authors.Add(prashant);
            Authors.Add(rikesh);
        }

        public void OnGet()
        {
            AuthorList = Authors.Select(author => new SelectListItem($"{author.FirstName} {author.LastName}", author.EmailAddress));
        }
        public void OnPost()
        {

        }
    }
}
