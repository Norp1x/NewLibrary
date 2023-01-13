using Microsoft.EntityFrameworkCore;
using NewLibrary.Models;

namespace NewLibrary.Data
{
    public class LibraryApiDbContext : DbContext
    {
        public LibraryApiDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
    }
}
