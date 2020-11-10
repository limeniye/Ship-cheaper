using Model.Entity;

namespace Model.Movie
{
    // Файл с событием Модели.

    /// <summary>Перечисление с указанием действий для списка.</summary>
    public enum ActionListEnum
    {
        /// <summary>Добавлены элементы.</summary>
        Added,
    }

    /// <summary>Делегат события.</summary>
    public delegate void ActionListHandler<T>(object sender, ActionListEnum action, T item);

    public partial class MovieModel
    {
        public event ActionListHandler<MovieDto> ActionMovies;

        private void RaiseActionMovies(ActionListEnum action, MovieDto movie)
            => ActionMovies?.Invoke(this, action, movie);
    }
}
