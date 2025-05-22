using BookStore.DataAccessLayer.Context;
using BookStore.WepApi.Mapping;
using MyMvcProject.Extensions;

var builder = WebApplication.CreateBuilder(args);

// AutoMapper i�in MappingProfile s�n�f� eklenmeli, �rn:
// builder.Services.AddAutoMapper(typeof(MappingProfile)); 
// Senin yoksa Program.cs'yi baz alabiliriz, ama MappingProfile olmal�

builder.Services.AddAutoMapper(typeof(ProductMapping)); // Burada Program baz al�n�yor, sorun olmaz.

builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();

// Extension metodu �a�r�larak servisler ekleniyor (DBContext + servisler)
builder.Services.AddMyDependencies(builder.Configuration);

// **Buradaki a�a��daki sat�r gereksiz, zaten yukar�da AddMyDependencies i�inde DbContext var. Tekrar eklemeye gerek yok**
// builder.Services.AddDbContext<BookStoreContext>(options =>
// {
//     options.UseLazyLoadingProxies()
//            .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
// });

var app = builder.Build();

// Pipeline ayarlar�
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
