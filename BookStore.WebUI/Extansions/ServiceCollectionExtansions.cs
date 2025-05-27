using BookStore.BusinessLayer.Abstract;
using BookStore.BusinessLayer.Concrete;
using BookStore.DataAccessLayer.Abstract;
using BookStore.DataAccessLayer.Context;
using BookStore.DataAccessLayer.EntityFramework;
using BookStore.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MyMvcProject.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookStoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Generic repository DI ekle
            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<IQuoteDal, EfQuoteDal>();
            services.AddScoped<IQuoteService, QuoteManager>();

            services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            services.AddScoped<ISubscribeService, SubscribeManager>();

            services.AddScoped<IFooterDal, EfFooterDal>();
            services.AddScoped<IFooterService, FooterManager>();
            // Diğer servisler varsa buraya eklenebilir

            return services;
        }
    }
}
