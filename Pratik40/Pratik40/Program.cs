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
 * Controller => Requesti ilk kar��layan k�s�md�r. �stekler buraya gelir ve buradan y�nlendirilir.
 * Action => Controller i�erisindeki IActionResult d�nen metotlard�r.
 * Model => View i�erisinde kullan�lan veri ta��y�c�d�r.
 * Razor => View i�erisinde kullan�lan bir template motorudur.
 * RazorView => cshtml uzant�l� dosyalard�r.
 * wwroot => statik dosyalar�n tutuldu�u klas�rd�r.
 * builder.Build() => Uygulamay� olu�turur.
 * app.Run() => Uygulamay� �al��t�r�r.
*/