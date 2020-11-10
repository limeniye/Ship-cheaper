using Common;
using System;
using System.Collections.ObjectModel;
using ViewModel.InterfaceViewModel;

namespace ViewModel
{
    public class MainViewModelBase : OnPropertyChangedClass, IMainViewModel
    {
        #region Private field
        private string _searchText;
        private ViewModeEnum _viewMode;
        private ViewModeContentEnum _viewContentMode;
        private Uri _imageDefault;
        #endregion

        #region Propertie
        public string SearchText { get => _searchText; set => SetProperty(ref _searchText, value); }
        public ViewModeEnum ViewMode { get => _viewMode; private set => SetProperty(ref _viewMode, value); }
        public Uri ImageDefault { get => _imageDefault; protected set => SetProperty(ref _imageDefault, value); }
        public ViewModeContentEnum ViewModeContent { get => _viewContentMode; private protected set => SetProperty(ref _viewContentMode, value); }
        #endregion

        #region Collection
        public ObservableCollection<IMovieVM> Movies { get; } = new ObservableCollection<IMovieVM>();
        #endregion

        #region Relay
        private RelayCommand _setViewModeCommand;
        public RelayCommand SetViewModeCommand => _setViewModeCommand ?? (_setViewModeCommand = new RelayCommand(p => ViewMode = (ViewModeEnum)p));

        private RelayCommand _searchCommand;
        public RelayCommand SearchCommand => _searchCommand ?? (_searchCommand = new RelayCommand(SearchMoviesMethod, SearchMoviesCanMethod));
        #endregion

        #region Method
        protected virtual bool SearchMoviesCanMethod(object parameter) { return true; }
        protected virtual void SearchMoviesMethod(object parameter) { throw new NotFiniteNumberException(); }
        #endregion

        #region Contructor
        /// <summary>Конструктор по умолчанию.
        /// Вызывается если не нужна связь с Моделью.</summary>
        public MainViewModelBase() : this(true) { }
        /// <summary>Универсальный конструктор.
        /// Может быть вызван только из производного класса.</summary>
        /// <param name="onlyView"><see langword="true"/>, если нужна
        /// демонстрационная инициализация коллекций.</param>
        protected MainViewModelBase(bool onlyView)
        {
            if (!onlyView)
                return;
        }
        #endregion
    }
}
