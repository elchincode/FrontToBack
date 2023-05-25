var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapDefaultControllerRoute();

// Same with option bellow

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=home}/{action-index}/{id?}"
//);

//Application will use static files
app.UseStaticFiles();

app.Run();
