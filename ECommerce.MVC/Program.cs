using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractService;
using ECommerce.BLL.Concrete;
using ECommerce.BLL.Service;
using ECommerce.DAL.Contex;
using System.Buffers.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Veritabanýný baðlýyoruz.
builder.Services.AddDbContext<EcommersContext>();
//Services

builder.Services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));//Tipine bakmamýz için kullanýyoruz.
builder.Services.AddScoped<ICategoryService, CategoryService>();//Program çalýþtýktan sonra bir kereliðne çalýþýr.


var app = builder.Build();//Hata verdi!!!!Veritabnaýný getirecek ama tanýmlama yapmadýðýmýz için hata veriyor.



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
