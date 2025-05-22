using BookStore.DataAccessLayer.Abstract;
using BookStore.DataAccessLayer.Context;
using BookStore.DataAccessLayer.Repositories;
using BookStore.EntityLayer.Concrete;

namespace BookStore.DataAccessLayer.EntityFramework
{
    public class EfFooterDal : GenericRepository<Footer>, IFooterDal
    {
        public EfFooterDal(BookStoreContext context) : base(context)
        {
        }
    }
}
