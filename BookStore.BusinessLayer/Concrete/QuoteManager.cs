using BookStore.BusinessLayer.Abstract;
using BookStore.DataAccessLayer.Abstract;
using BookStore.EntityLayer.Concrete;

namespace BookStore.BusinessLayer.Concrete
{
    public class QuoteManager : GenericManager<Quote>, IQuoteService
    {
        private readonly IQuoteDal _quoteDal;

        public QuoteManager(IQuoteDal quoteDal) : base(quoteDal)
        {
            _quoteDal = quoteDal;
        }

        public List<Quote> TGetQuoteWithAuthors()
        {
            return _quoteDal.GetQuoteWithAuthors();
        }
    }
}
