using Microsoft.Extensions.DependencyInjection;

namespace WorldCount.RussianPost.PostApp.DwUtils.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
