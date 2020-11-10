using System;
using System.Drawing;

namespace Model.Entity
{
    /// <summary>
    /// Dto-класс описывающий стрктуру Фильма.
    /// </summary>
    public class MovieDto
    {
        /// <summary>Уникальный идентификатор.</summary>
        public int Id { get; }

        /// <summary>Id фильма.</summary>
        public string ImdbID { get; }

        /// <summary>Назание фильма.</summary>
        public string Name { get; }

        /// <summary>Длительность фильма.</summary>
        public TimeSpan Runtime { get; }

        /// <summary>Дата выхода фильма.</summary>
        public int Year { get; }

        /// <summary>Фото обложки фильма.</summary>
        public string PhotoLink { get; }

        /// <summary>Жанр фильма.</summary>
        public string Genre { get; }

        /// <summary>Описание фильма.</summary>
        public string Writer { get; }

        /// <summary>Статус понравился ли фильм.</summary>
        public bool FavoriteStatus { get; }

        public MovieDto(int id, string imdbID, string name, TimeSpan runtime, int year, string genre, string writer, bool favoriteStatus)
        {
            Id = id; ImdbID = imdbID; Name = name; Runtime = runtime; Year = year; Genre = genre; Writer = writer; FavoriteStatus = favoriteStatus;
        }
        public MovieDto(int id, string imdbID, string name, TimeSpan runtime, int year, string genre, string writer, bool favoriteStatus, string photoLink)
            : this(id, imdbID, name, runtime, year, genre, writer, favoriteStatus)
        {
            PhotoLink = photoLink;
        }
    }
}
