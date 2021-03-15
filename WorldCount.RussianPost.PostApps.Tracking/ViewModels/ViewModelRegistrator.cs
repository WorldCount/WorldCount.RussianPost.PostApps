using Microsoft.Extensions.DependencyInjection;

namespace WorldCount.RussianPost.PostApps.Tracking.ViewModels
{
    internal static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>();
    }
}
