using Microsoft.Extensions.DependencyInjection;
using WorldCount.RussianPost.PostApp.DwUtils.Services.Interfaces;

namespace WorldCount.RussianPost.PostApp.DwUtils.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IDataService, DataService>()
            .AddTransient<IUserDialog, UserDialogService>();
    }
}
