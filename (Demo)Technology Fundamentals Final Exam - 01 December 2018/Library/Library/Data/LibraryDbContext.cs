namespace Library.Data
{
    using Microsoft.EntityFrameworkCore;
    using Library.Models;

    public class LibraryDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=Library;Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; }
    }
}
