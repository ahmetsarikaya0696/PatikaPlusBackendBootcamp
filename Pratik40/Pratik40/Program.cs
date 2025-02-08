var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

/*
 * Controller => Requesti ilk karþýlayan kýsýmdýr. Ýstekler buraya gelir ve buradan yönlendirilir.
 * Action => Controller içerisindeki IActionResult dönen metotlardýr.
 * Model => View içerisinde kullanýlan veri taþýyýcýdýr.
 * Razor => View içerisinde kullanýlan bir template motorudur.
 * RazorView => cshtml uzantýlý dosyalardýr.
 * wwroot => statik dosyalarýn tutulduðu klasördür.
 * builder.Build() => Uygulamayý oluþturur.
 * app.Run() => Uygulamayý çalýþtýrýr.
*/