using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment_4.Models;

namespace Assignment_4.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment_4.Models.Book> Book { get; set; } = default!;
    }
}
