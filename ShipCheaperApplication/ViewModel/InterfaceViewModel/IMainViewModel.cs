using Common;

namespace ViewModel.InterfaceViewModel
{
    /// <summary>Перечисление Режимов Отображения.</summary>
    public enum ViewModeEnum { Empty, Search, Favorite, AboutApplication }
    /// <summary>Перечисление Режимов Отображения контента.</summary>
    public enum ViewModeContentEnum { Empty, ListActive }
    /// <summary>Интерфейс основной ViewModel.</summary>
    public interface IMainViewModel : IMoviesList
    {
        /// <summary>Режим отображения.</summary>
        ViewModeEnum ViewMode { get; }

        string SearchText { get; set; }
        ViewModeContentEnum ViewModeContent { get; }

        RelayCommand SetViewModeCommand { get; }

        RelayCommand SearchCommand { get; }

    }
}
