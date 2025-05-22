using BookStore.BusinessLayer.Abstract;
using BookStore.BusinessLayer.Concrete;
using BookStore.DataAccessLayer.Abstract;
using BookStore.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace MyMvcProject.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookStoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            // Diğer servisler varsa buraya eklenebilir

            return services;
        }
    }
}
