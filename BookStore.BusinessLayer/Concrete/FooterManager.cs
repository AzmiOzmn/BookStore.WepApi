using BookStore.BusinessLayer.Abstract;
using BookStore.DataAccessLayer.Abstract;
using BookStore.EntityLayer.Concrete;

namespace BookStore.BusinessLayer.Concrete
{
    public class FooterManager : GenericManager<Footer>, IFooterService
    {
        public FooterManager(IGenericDal<Footer> genericDal) : base(genericDal)
        {
        }
    }
}
