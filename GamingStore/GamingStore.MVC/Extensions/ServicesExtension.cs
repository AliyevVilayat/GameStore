using GamingStore.MVC.Contexts;
using GamingStore.MVC.Helpers;
using GamingStore.MVC.Services;
using Microsoft.EntityFrameworkCore;

namespace GamingStore.MVC.Extensions;

public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services)
    {

        //DbContext
        services.AddDbContext<GamingStoreDbContext>(opt =>
        {
            opt.UseSqlServer(Configurations.GetConnectionStr());
        });


        //Scopes
        services.AddScoped<IGameService, GameService>();
    }
}
