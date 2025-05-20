using BookStore.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccessLayer.Context
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { } 
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}
