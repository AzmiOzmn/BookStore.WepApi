using System.Text.Json.Serialization;

namespace BookStore.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }

        public string? ImageUrl { get; set; }


        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }

        public int AuthorId { get; set; }
        [JsonIgnore]
        public virtual Author? Author { get; set; }

    }
}
