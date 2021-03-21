using Microsoft.Extensions.DependencyInjection;

namespace WorldCount.RussianPost.PostApp.DwUtils.ViewModels
{
    internal static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>();
    }
}
