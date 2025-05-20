namespace BookStore.EntityLayer.Concrete
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public string Description { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
