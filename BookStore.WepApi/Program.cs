using BookStore.BusinessLayer.Abstract;
using BookStore.BusinessLayer.Concrete;
using BookStore.DataAccessLayer.Abstract;
using BookStore.DataAccessLayer.Context;
using BookStore.DataAccessLayer.EntityFramework;
using BookStore.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BookStoreContext>(options =>
{
    options.UseLazyLoadingProxies()
           .UseSqlServer("Server=DESKTOP-V5FSJOQ\\OZMEN;Database=BookStore;Integrated Security=true;");
});
builder.Services.AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);


builder.Services.AddScoped(typeof(IGenericDal<>),typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>),typeof(GenericManager<>));
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddAutoMapper(typeof(Program));



builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();
builder.Services.AddScoped<ICategoryService,CategoryManager>();

builder.Services.AddScoped<IProductDal,EfProductDal>();
builder.Services.AddScoped<IProductService,ProductManager>();

builder.Services.AddScoped<IAuthorDal, EfAuthorDal>();
builder.Services.AddScoped<IAuthorService, AuthorManager>();


builder.Services.AddScoped<IBannerDal, EfBannerDal>();
builder.Services.AddScoped<IBannerService, BannerManager>();





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
