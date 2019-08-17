namespace BandRegister.Data
{
    using BandRegister.Models;
    using Microsoft.EntityFrameworkCore;

    public class BandRegisterDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=BandRegister;Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Band> Bands { get; set; }
    }
}
