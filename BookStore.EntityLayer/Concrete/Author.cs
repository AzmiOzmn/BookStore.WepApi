using System.Text.Json.Serialization;

namespace BookStore.EntityLayer.Concrete
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; }

        [JsonIgnore]
        public virtual IList<Product>? Products { get; set; }

        [JsonIgnore]
        public virtual IList<Quote>? Quotes { get; set; }
    }
}
