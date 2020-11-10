using Model.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Model.Movie
{
    public partial class MovieModel
    {
        /// <summary>Приватный изменяемый словарь фильмов.</summary>
        private readonly Dictionary<int, MovieDto> movieDict;
        /// <summary>Публичный неизменяемый словарь сотрудников.</summary>
        public ReadOnlyDictionary<int, MovieDto> Movies { get; }


        /// <summary>Конструктор Модели</summary>
        public MovieModel()
        {
            movieDict = new MovieDto[]
            {
                new MovieDto(0, "yaf", "Роки", new TimeSpan(1,30,54), 1984, "Ужасы", "Это лол кекный чебукчай", true, "https://upload.wikimedia.org/wikipedia/ru/thumb/1/18/Rocky_poster.jpg/315px-Rocky_poster.jpg"),
                new MovieDto(1, "33", "Кек", new TimeSpan(1,30,54), 1984, "Ужасы", "Это лол кекный чебукчай", false, "https://www.kino-teatr.ru/movie/poster/117171.jpg"),
                new MovieDto(2, "fasf",  "Лол", new TimeSpan(1,30,54), 1984, "Ужасы", "Это лол кекный чебукчай", true, "https://www.kinopoisk.ru/film/495017/posters/"),
                new MovieDto(3, "gygaf",  "Азазек", new TimeSpan(1,30,54), 1984, "Ужасы", "Это лол кекный чебукчай", true),
                new MovieDto(4, "gasgas",  "Чебукрчай", new TimeSpan(1,30,54), 1984, "Ужасы", "Это лол кекный чебукчай", true)
            }
            .ToDictionary(mov => mov.Id);

            Movies = new ReadOnlyDictionary<int, MovieDto>(movieDict);
        }
    }
}
