using GamingStore.MVC.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddServices();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(

    name: "default",
    pattern: "{Controller=Home}/{Action=Index}/{id?}");

app.Run();
