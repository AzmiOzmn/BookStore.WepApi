using System.Text.Json.Serialization;

namespace BookStore.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        [JsonIgnore]
        public virtual IList<Product> Products { get; set; }


    }
}
