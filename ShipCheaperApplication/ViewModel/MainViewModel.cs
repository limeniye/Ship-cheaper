using Model.Entity;
using Model.Movie;
using System;
using System.Linq;
using ViewModel.InterfaceViewModel;

namespace ViewModel
{
    public class MainViewModel : MainViewModelBase
    {
        private readonly MovieModel model;
        public MainViewModel(MovieModel model) : base(false)
        {
            this.model = model;
            model.ActionMovies += Model_ActionMovies;

            foreach (MovieDto movie in model.Movies.Values)
                AddingMovie(movie);

            ImageDefault = new Uri("..\\..\\Picture/Empty.png", UriKind.Relative);

        }
        private void Model_ActionMovies(object sender, ActionListEnum action, MovieDto item)
        {
            switch (action)
            {
                case ActionListEnum.Added:
                    AddingMovie(item);
                    break;
                default:
                    throw new ArgumentException(nameof(action));
            }
        }

        /// <summary>Добавление Фильма в список.</summary>
        /// <param name="item">Добавляемый Фильм.</param>
        private void AddingMovie(MovieDto movie)
        {
            MovieViewModel movieVm = (MovieViewModel)Movies.FirstOrDefault(mov => mov.Id == movie.Id);
            if (movieVm == null)
                Movies.Add(new MovieViewModel(movie));
            else
                movieVm.SetDto(movie);
            ViewModeContent = ViewModeContentEnum.ListActive;
        }

        protected override async void SearchMoviesMethod(object parameter)
        {
            if (!SearchMoviesCanMethod(parameter))
                return;

            string text = parameter.ToString();

            Movies.Clear();
            await model.SearchMovies(text);
        }
    }
}
