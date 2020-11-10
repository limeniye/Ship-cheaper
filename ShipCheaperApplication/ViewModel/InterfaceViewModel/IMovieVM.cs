using System;

namespace ViewModel.InterfaceViewModel
{
    /// <summary>Интерфейс элемента Фильм.</summary>
    public interface IMovieVM
    {
        /// <summary>Уникальный идентификатор.</summary>
        int Id { get; }

        /// <summary>Назание фильма.</summary>
        string Name { get; set; }

        /// <summary>Длительность фильма.</summary>
        TimeSpan Runtime { get; set; }

        /// <summary>Дата выхода фильма.</summary>
        int Year { get; set; }

        /// <summary>Жанр фильма.</summary>
        string Genre { get; set; }

        /// <summary>Описание фильма.</summary>
        string Writer { get; set; }

        /// <summary>Статус понравился ли фильм.</summary>
        bool FavoriteStatus { get; set; }

        // Возможно здесь нужен тип не Uri, а string или object
        Uri ImageUri { get; set; }

    }
}
