using Common;
using Model.Entity;
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ViewModel.InterfaceViewModel;

namespace ViewModel
{
    public class MovieViewModel : OnPropertyChangedClass, IMovieVM
    {
        #region Field
        private int _id, _year;
        private string _name, _genre, _writer;
        private TimeSpan _runtime;
        private bool _status;
        private MovieDto _dto;
        private Uri _imageUri;
        #endregion

        #region Property
        public int Id { get => _id; private set => SetProperty(ref _id, value); }
        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public TimeSpan Runtime { get => _runtime; set => SetProperty(ref _runtime, value); }
        public int Year { get => _year; set => SetProperty(ref _year, value); }
        public string Genre { get => _genre; set => SetProperty(ref _genre, value); }
        public string Writer { get => _writer; set => SetProperty(ref _writer, value); }
        public bool FavoriteStatus { get => _status; set => SetProperty(ref _status, value); }
        public MovieDto Dto { get => _dto; private set => SetProperty(ref _dto, value); }
        public Uri ImageUri { get => _imageUri; set => SetProperty(ref _imageUri, value); } //TODO:Возможно здесь нужен тип не Uri
        #endregion
        public void CopyFrom(MovieDto obj)
        {
            Id = obj.Id;
            Name = obj.Name;
            Runtime = obj.Runtime;
            Year = obj.Year;
            Genre = obj.Genre;
            Writer = obj.Writer;
            FavoriteStatus = obj.FavoriteStatus;

            //TODO:Возможно здесь нужное другое преобразование, или должен быть другой тип у ImageUri
            ImageUri = string.IsNullOrWhiteSpace(obj.PhotoLink) ? null : new Uri(obj.PhotoLink);
        }
        public MovieViewModel(MovieDto dto) => SetDto(dto);
        public void SetDto(MovieDto dto) => CopyFrom(Dto = dto);

    }
}
