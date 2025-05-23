namespace BookStore.DtoLayer.QuoteDtos
{
    public class ResultQuoteDto
    {
        public int QuoteId { get; set; }
        public string Description { get; set; }


        public int AuthorId { get; set; }
        public string? AuthorName { get; set; }
    }
}
