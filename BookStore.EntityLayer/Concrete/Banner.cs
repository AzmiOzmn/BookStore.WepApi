using System.Text.Json.Serialization;

namespace BookStore.EntityLayer.Concrete
{
    public class Banner
    {
        public int BannerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int ProductId { get; set; }
        [JsonIgnore]
        public virtual Product? Product { get; set; }
    }
}
