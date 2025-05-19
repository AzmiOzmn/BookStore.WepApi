using BookStore.BusinessLayer.Abstract;
using BookStore.DataAccessLayer.Abstract;
using BookStore.EntityLayer.Concrete;

namespace BookStore.BusinessLayer.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal) : base(productDal)
        {
            _productDal = productDal;
        }

        public int TGetProductCount()
        {
            return _productDal.GetProductCount(); 
        }
    }
}
