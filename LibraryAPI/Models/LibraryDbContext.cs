using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id=1,Title="Title 1",Description="Description 1",Author="Author 1",Rating=3.9,CoverUrl="https://www.book1.com"},
                new Book { Id=2,Title="Title 2",Description="Description 2",Author="Author 2",Rating=3.9,CoverUrl="https://www.book2.com"},
                new Book { Id=3,Title="Title 3",Description="Description 3",Author="Author 3",Rating=3.9,CoverUrl="https://www.book3.com"},
                new Book { Id=4,Title="Title 4",Description="Description 4",Author="Author 4",Rating=3.9,CoverUrl="https://www.book4.com"},
                new Book { Id=5,Title="Title 5",Description="Description 5",Author="Author 5",Rating=3.9,CoverUrl="https://www.book5.com"}
                );
        }
    }
}
