using Common;
using IMDB;
using Model.Entity;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Model.Movie
{
    public partial class MovieModel
    {
        /// <summary>ГСЧ.</summary>
        private static readonly Random random = new Random();

        /// <summary>Поиск новых фильмов.</summary>
        /// <param name="name">Название.</param>
        public async Task SearchMovies(string name)
        {
            //TODO: если тут будет цикл то нужно будет вернуть проверку
            // Получение слуяайного уникального идентификатора.
            int id = random.Next();

            TimeConverter timeConverter = new TimeConverter();
            var imdb = new Imdb("9d84e8a1");
            var movie = await imdb.GetMovieAsync(name);
            var imdbId = movie.Error ?? movie.ImdbId;
            var title = movie.Error ?? movie.Title;
            var runtime = movie.Error ?? movie.RunTime;
            var year = movie.Error ?? movie.Year;
            var photo = movie.Error ?? movie.Poster;
            var gener = movie.Error ?? movie.Genre;
            var writer = movie.Error ?? movie.Writer;

            //TODO: в базе данных должен искаться этот елемент и значение должно меняться
            bool status = false;

            String[] onlyMinutes = runtime.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            MovieDto movieNew = new MovieDto(id, imdbId, title, timeConverter.MinuteToTimeConverter(Convert.ToInt32(onlyMinutes[0])), Convert.ToInt32(year), gener, writer, status, photo);
            movieDict.Clear();

            AddMovie(movieNew);

        }

        /// <summary>Добавление в список новго фильма.</summary>
        /// <param name="movie">Данные нового фильма.</param>
        public void AddMovie(MovieDto movie)
        {
            // Получение DTO с данными фильма и запись его в приватный словарь.
            MovieDto movieNew = new MovieDto(movie.Id, movie.ImdbID, movie.Name, movie.Runtime, movie.Year, movie.Genre, movie.Writer, movie.FavoriteStatus);
            movieDict.Add(movie.Id, movieNew);

            // Создание события, уведомляющего о добавлениии элемента в коллекцию.
            RaiseActionMovies(ActionListEnum.Added, movieNew);
        }

        private Image GetImage(string uri)
        {
            return Bitmap.FromStream(new MemoryStream(new WebClient().DownloadData("https://www.google.co.uk/images/srpr/logo11w.png")));
        }
    }
}
