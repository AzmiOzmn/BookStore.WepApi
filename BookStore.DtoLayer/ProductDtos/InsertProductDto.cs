using BookStore.EntityLayer.Concrete;
using System.Text.Json.Serialization;

namespace BookStore.DtoLayer.ProductDtos
{
    public class InsertProductDto
    {
       
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal Description { get; set; }
        public decimal Title { get; set; }

        public int CategoryId { get; set; }
        
      
        public int AuthorId { get; set; }
       
  
    }
}

