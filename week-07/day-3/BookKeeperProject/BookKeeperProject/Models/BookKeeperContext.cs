using Microsoft.EntityFrameworkCore;
using BookKeeperProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeperProject.Models
{
    public class BookKeeperContext : DbContext
    {
        

        public BookKeeperContext(DbContextOptions<BookKeeperContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
