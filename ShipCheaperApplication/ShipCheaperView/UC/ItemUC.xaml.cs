using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ViewModel;

namespace ShipCheaperView.UC
{
    public partial class ItemUC : UserControl
    {
        #region Titel DependencyProperty

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string),
              typeof(ItemUC), new PropertyMetadata(null));

        public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
        #endregion

        #region Genre DependencyProperty

        public static readonly DependencyProperty GenreProperty =
            DependencyProperty.Register("Genre", typeof(object),
              typeof(ItemUC), new PropertyMetadata(null));

        public object Genre { get => (object)GetValue(GenreProperty); set => SetValue(GenreProperty, value); }
        #endregion

        #region Runtime DependencyProperty

        public static readonly DependencyProperty RuntimeProperty =
            DependencyProperty.Register("Runtime", typeof(object),
              typeof(ItemUC), new PropertyMetadata(null));

        public object Runtime { get => (object)GetValue(RuntimeProperty); set => SetValue(RuntimeProperty, value); }
        #endregion

        #region Year DependencyProperty

        public static readonly DependencyProperty YearProperty =
            DependencyProperty.Register("Year", typeof(object),
              typeof(ItemUC), new PropertyMetadata(null));

        public object Year { get => (object)GetValue(YearProperty); set => SetValue(YearProperty, value); }
        #endregion

        #region Writer DependencyProperty

        public static readonly DependencyProperty WriterProperty =
            DependencyProperty.Register("Writer", typeof(object),
              typeof(ItemUC), new PropertyMetadata(null));

        public object Writer { get => (object)GetValue(WriterProperty); set => SetValue(WriterProperty, value); }
        #endregion

        #region Favorit DependencyProperty

        public static readonly DependencyProperty FavoritProperty =
            DependencyProperty.Register("Favorit", typeof(object),
              typeof(ItemUC), new PropertyMetadata(null));

        public object Favorit { get => (object)GetValue(FavoritProperty); set => SetValue(FavoritProperty, value); }
        #endregion

        #region Photo DependencyProperty

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(object),
              typeof(ItemUC), new PropertyMetadata(null));

        public object Image { get => (object)GetValue(ImageProperty); set => SetValue(ImageProperty, value); }
        #endregion
        public ItemUC()
        {
            InitializeComponent();

            image = (ImageAsync)Resources["image"];
        }
        private readonly ImageAsync image;



        public ImageSource ImageDefault
        {
            get { return (ImageSource)GetValue(ImageDefaultProperty); }
            set { SetValue(ImageDefaultProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageDefault.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageDefaultProperty =
            DependencyProperty.Register(nameof(ImageDefault), typeof(ImageSource), typeof(ItemUC), new PropertyMetadata(null, ChangeDefaultProperty));

        private static void ChangeDefaultProperty(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ItemUC)d).image.ImageDefault = (ImageSource)e.NewValue;
        }

        // Возможно нужен тип не Uri
        public Uri ImageSource
        {
            get { return (Uri)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register(nameof(ImageSource), typeof(Uri), typeof(ItemUC), new PropertyMetadata(null, ChangeImageSource));

        private static void ChangeImageSource(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ItemUC)d).image.ImageUri = e.NewValue;
        }
    }
}
