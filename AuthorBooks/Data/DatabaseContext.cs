using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorBooks.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
