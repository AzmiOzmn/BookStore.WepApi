using BookStore.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccessLayer.Context
{
    public class BookStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V5FSJOQ\\OZMEN;Database=BookStore;integrated security=true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
