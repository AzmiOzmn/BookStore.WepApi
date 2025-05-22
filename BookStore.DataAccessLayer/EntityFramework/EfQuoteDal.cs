using BookStore.DataAccessLayer.Abstract;
using BookStore.DataAccessLayer.Context;
using BookStore.DataAccessLayer.Repositories;
using BookStore.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccessLayer.EntityFramework
{
    public class EfQuoteDal : GenericRepository<Quote>, IQuoteDal
    {
        private readonly BookStoreContext _context;

        public EfQuoteDal(BookStoreContext context) : base(context)
        {
            _context = context;
        }

        public List<Quote> GetQuoteWithAuthors()
        {
            return _context.Quotes.Include(x => x.Author).ToList();
        }
    }
}
