using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApplication.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }
}
