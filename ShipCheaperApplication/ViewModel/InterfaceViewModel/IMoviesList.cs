using System;
using System.Collections.ObjectModel;

namespace ViewModel.InterfaceViewModel
{
    /// <summary>Интерфейс списка Фильмов</summary>
    public interface IMoviesList
    {
        /// <summary>Коллекция Фильмов.</summary>
        ObservableCollection<IMovieVM> Movies { get; }
        Uri ImageDefault { get; }
    }
}
