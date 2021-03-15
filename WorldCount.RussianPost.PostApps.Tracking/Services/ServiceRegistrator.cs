using Microsoft.Extensions.DependencyInjection;
using WorldCount.RussianPost.PostApps.Tracking.Services.Interfaces;

namespace WorldCount.RussianPost.PostApps.Tracking.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IDataService, DataService>()
            .AddTransient<IUserDialog, UserDialogService>();
    }
}
