using BookStore.BusinessLayer.Abstract;
using BookStore.DataAccessLayer.Abstract;
using BookStore.EntityLayer.Concrete;

namespace BookStore.BusinessLayer.Concrete
{
    public class AuthorManager : GenericManager<Author>, IAuthorService
    {
        public AuthorManager(IGenericDal<Author> genericDal) : base(genericDal)
        {
        }
    }
}
