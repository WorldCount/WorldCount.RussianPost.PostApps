using Microsoft.Extensions.DependencyInjection;

namespace WorldCount.RussianPost.PostApps.Tracking.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
