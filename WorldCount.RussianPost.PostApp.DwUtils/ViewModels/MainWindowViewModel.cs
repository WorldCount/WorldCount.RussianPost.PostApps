using WorldCount.RussianPost.PostApp.DwUtils.Services.Interfaces;
using WorldCount.RussianPost.PostApp.DwUtils.ViewModels.Base;

namespace WorldCount.RussianPost.PostApp.DwUtils.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private readonly IUserDialog _userDialog;
        private readonly IDataService _dataService;

        #region Title : string - Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _title = "DwUtils";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        #endregion

        #region Status : string - Статус

        /// <summary>Статус</summary>
        private string _status = "Готов!";

        /// <summary>Статус</summary>
        public string Status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        #endregion

        public MainWindowViewModel(IUserDialog userDialog, IDataService dataService)
        {
            _userDialog = userDialog;
            _dataService = dataService;
        }
    }
}
