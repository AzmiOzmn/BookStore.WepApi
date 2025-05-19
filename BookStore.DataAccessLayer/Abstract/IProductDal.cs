using BookStore.EntityLayer.Concrete;

namespace BookStore.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        int GetProductCount();
    }
}
