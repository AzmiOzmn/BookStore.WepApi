using BookStore.DataAccessLayer.Context;
using BookStore.WepApi.Mapping;
using MyMvcProject.Extensions;

var builder = WebApplication.CreateBuilder(args);

// AutoMapper için MappingProfile sýnýfý eklenmeli, örn:
// builder.Services.AddAutoMapper(typeof(MappingProfile)); 
// Senin yoksa Program.cs'yi baz alabiliriz, ama MappingProfile olmalý

builder.Services.AddAutoMapper(typeof(ProductMapping)); // Burada Program baz alýnýyor, sorun olmaz.

builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();

// Extension metodu çaðrýlarak servisler ekleniyor (DBContext + servisler)
builder.Services.AddMyDependencies(builder.Configuration);

// **Buradaki aþaðýdaki satýr gereksiz, zaten yukarýda AddMyDependencies içinde DbContext var. Tekrar eklemeye gerek yok**
// builder.Services.AddDbContext<BookStoreContext>(options =>
// {
//     options.UseLazyLoadingProxies()
//            .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
// });

var app = builder.Build();

// Pipeline ayarlarý
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
