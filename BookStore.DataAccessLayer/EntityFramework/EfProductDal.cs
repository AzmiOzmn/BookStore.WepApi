using BookStore.DataAccessLayer.Abstract;
using BookStore.DataAccessLayer.Context;
using BookStore.DataAccessLayer.Repositories;
using BookStore.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    private readonly BookStoreContext _context;

    public EfProductDal(BookStoreContext context) : base(context)
    {
        _context = context;
    }

    public List<Product> GetProductWithAuthors()
    {
        return _context.Products.Include(x => x.Author).ToList();
    }
}
