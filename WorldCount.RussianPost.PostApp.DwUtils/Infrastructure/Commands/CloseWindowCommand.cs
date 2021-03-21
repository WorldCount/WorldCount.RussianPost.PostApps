using System.Windows;
using WorldCount.RussianPost.PostApp.DwUtils.Infrastructure.Commands.Base;

namespace WorldCount.RussianPost.PostApp.DwUtils.Infrastructure.Commands
{
    class CloseWindowCommand : Command
    {
        private static Window GetWindow(object p) => p as Window ?? App.FocusedWindow ?? App.ActivedWindow;

        protected override bool CanExecute(object p) => GetWindow(p) != null;

        protected override void Execute(object p) => GetWindow(p)?.Close();
    }
}
