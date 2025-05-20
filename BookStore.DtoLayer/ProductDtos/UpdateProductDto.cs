using BookStore.EntityLayer.Concrete;
using System.Text.Json.Serialization;

namespace BookStore.DtoLayer.ProductDtos
{
    public class UpdateProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }

        public int CategoryId { get; set; }
      

        public int AuthorId { get; set; }
       
    }
}

