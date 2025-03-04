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
 * Controller => Requesti ilk karşılayan kısımdır. İstekler buraya gelir ve buradan yönlendirilir.
 * Action => Controller içerisindeki IActionResult dönen metotlardır.
 * Model => View içerisinde kullanılan veri taşıyıcıdır.
 * Razor => View içerisinde kullanılan bir template motorudur.
 * RazorView => cshtml uzantılı dosyalardır.
 * wwroot => statik dosyaların tutulduğu klasördür.
 * builder.Build() => Uygulamayı oluşturur.
 * app.Run() => Uygulamayı çalıştırır.
*/