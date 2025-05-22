using BookStore.EntityLayer.Concrete;

namespace BookStore.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
       
        List<Product> TGetProductWithAuthors();
    }
}
