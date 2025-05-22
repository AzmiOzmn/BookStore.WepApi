using BookStore.EntityLayer.Concrete;

namespace BookStore.BusinessLayer.Abstract
{
    public interface IQuoteService : IGenericService<Quote>
    {
        List<Quote> TGetQuoteWithAuthors();
    }
}
