using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractService;
using ECommerce.BLL.Concrete;
using ECommerce.BLL.Service;
using ECommerce.DAL.Contex;
using System.Buffers.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Veritaban�n� ba�l�yoruz.
builder.Services.AddDbContext<EcommersContext>();
//Services

builder.Services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));//Tipine bakmam�z i�in kullan�yoruz.
builder.Services.AddScoped<ICategoryService, CategoryService>();//Program �al��t�ktan sonra bir kereli�ne �al���r.


var app = builder.Build();//Hata verdi!!!!Veritabna�n� getirecek ama tan�mlama yapmad���m�z i�in hata veriyor.



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
