using BookStore.DataAccessLayer.Abstract;
using BookStore.DataAccessLayer.Context;
using BookStore.DataAccessLayer.Repositories;
using BookStore.EntityLayer.Concrete;

namespace BookStore.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly BookStoreContext _context;

        public EfProductDal(BookStoreContext context) : base(context)
        {
            _context = context;
        }

        public int GetProductCount()
        {
            return _context.Products.Count();
        }
    }
}
