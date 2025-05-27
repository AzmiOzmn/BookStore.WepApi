using BookStore.BusinessLayer.Abstract;
using BookStore.DataAccessLayer.Abstract;
using BookStore.EntityLayer.Concrete;

namespace BookStore.BusinessLayer.Concrete
{
    public class SubscribeManager : GenericManager<Subscribe>, ISubscribeService
    {
        ISubscribeDal subscribes;
        public SubscribeManager(IGenericDal<Subscribe> genericDal, ISubscribeDal subscribe) : base(genericDal)
        {
            this.subscribes = subscribe;
        }

        
    }
}
