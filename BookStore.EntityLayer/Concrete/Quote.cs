using System.Text.Json.Serialization;

namespace BookStore.EntityLayer.Concrete
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public string Description { get; set; }

        
        public int AuthorId { get; set; }
        [JsonIgnore]
        public virtual Author Author { get; set; }
    }
}
