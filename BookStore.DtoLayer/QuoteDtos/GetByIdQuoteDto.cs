namespace BookStore.DtoLayer.QuoteDtos
{
    public class GetByIdQuoteDto
    {
        public int QuoteId { get; set; }
        public string Description { get; set; }


        public int AuthorId { get; set; }
    }
}
