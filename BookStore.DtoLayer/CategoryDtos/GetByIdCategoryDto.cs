using BookStore.EntityLayer.Concrete;
using System.Text.Json.Serialization;

namespace BookStore.DtoLayer.CategoryDtos
{
    public class GetByIdCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
    }
}
