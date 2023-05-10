using MVC_Injection.Database;
using MVC_Injection.Repository;
using MVC_Injection.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc();

//Injection

//Scoped => her istekle beraber sadece 1 instance verir.
//Singleton => her istek gerçekleþtirildiðinde isteði kontrol eder ve sadece 1 adet instance verir.
//Transient => her istek gerçekleþtirildiðinde ayrý ayrý instance verir.

builder.Services.AddTransient<ICategoryRepository, CategoryService>();

builder.Services.AddTransient<IProductRepository, ProductService>();

builder.Services.AddTransient<ISupplierRepository, SupplierService>();



var app = builder.Build();

//url rotasý aktif edilmesi.
app.UseRouting();

//wwwroot aktif edilmesi
app.UseStaticFiles();


//varsayýlan url

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();

});

app.Run();
