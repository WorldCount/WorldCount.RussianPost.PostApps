using System.Windows;
using WorldCount.RussianPost.PostApp.DwUtils.Services.Interfaces;

namespace WorldCount.RussianPost.PostApp.DwUtils.Services
{
    internal class UserDialogService : IUserDialog
    {
        public void Information(string title, string message) =>
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);

        public void Warning(string title, string message) =>
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Warning);

        public void Error(string title, string message) =>
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error);
    }
}
