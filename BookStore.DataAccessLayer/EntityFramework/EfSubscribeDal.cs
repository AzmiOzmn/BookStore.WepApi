using BookStore.DataAccessLayer.Abstract;
using BookStore.DataAccessLayer.Context;
using BookStore.DataAccessLayer.Repositories;
using BookStore.EntityLayer.Concrete;

namespace BookStore.DataAccessLayer.EntityFramework
{
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(BookStoreContext context) : base(context)
        {
        }
    }
}
