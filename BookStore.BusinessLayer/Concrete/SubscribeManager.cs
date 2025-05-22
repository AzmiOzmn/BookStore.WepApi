using BookStore.BusinessLayer.Abstract;
using BookStore.DataAccessLayer.Abstract;
using BookStore.EntityLayer.Concrete;

namespace BookStore.BusinessLayer.Concrete
{
    public class SubscribeManager : GenericManager<Subscribe>, ISubscribeService
    {
        public SubscribeManager(IGenericDal<Subscribe> genericDal) : base(genericDal)
        {
        }
    }
}
