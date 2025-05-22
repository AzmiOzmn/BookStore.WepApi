using BookStore.EntityLayer.Concrete;

namespace BookStore.DataAccessLayer.Abstract
{
    public interface IQuoteDal : IGenericDal<Quote>
    {
        List<Quote> GetQuoteWithAuthors();
    }
    
    
}
