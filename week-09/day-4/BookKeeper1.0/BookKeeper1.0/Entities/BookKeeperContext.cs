using BookKeeper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeper.Entities
{
    public class BookKeeperContext : DbContext
    {
        public BookKeeperContext(DbContextOptions<BookKeeperContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
