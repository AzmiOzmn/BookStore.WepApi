using BookStore.BusinessLayer.Abstract;
using BookStore.DataAccessLayer.Abstract;
using BookStore.EntityLayer.Concrete;

namespace BookStore.BusinessLayer.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
        }

        public List<Category> CategoryNameLength()
        {
            var categories = TGetAll();
            var filteredCategories = categories.Where(c => c.CategoryName.Length > 3).ToList();
            if (filteredCategories.Count == 0)
            {
                throw new Exception("No categories found with names longer than 3 characters.");
            }
            return filteredCategories;

        }
    }
}
