using BookStore.DataAccessLayer.Abstract;
using BookStore.DataAccessLayer.Context;

namespace BookStore.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly BookStoreContext context;

        public GenericRepository(BookStoreContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            var value = context.Set<T>().Find(id);
            context.Set<T>().Remove(value);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
