using System;
using System.Windows;
using System.Windows.Media;

namespace ShipCheaperView.UC
{
    public class ProxyImage : Freezable
    {
        public Uri UriImage
        {
            get => (Uri)GetValue(UriImageProperty);
            set => SetValue(UriImageProperty, value);
        }

        // Using a DependencyProperty as the backing store for UriImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UriImageProperty =
            DependencyProperty.Register(nameof(UriImage), typeof(Uri), typeof(ProxyImage), new PropertyMetadata(null, UriChamged));

        private static void UriChamged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ProxyImage)d).Image = e.NewValue != null
                ? (ImageSource)imageSourceConverter.ConvertFrom((Uri)e.NewValue)
                : null;
        }

        private static ImageSourceConverter imageSourceConverter = new ImageSourceConverter();

        public ImageSource Image
        {
            get => (ImageSource)GetValue(ImageProperty);
            private set => SetValue(ImagePropertyKey, value);
        }

        // Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
        public static readonly DependencyPropertyKey ImagePropertyKey =
            DependencyProperty.RegisterReadOnly(nameof(Image), typeof(ImageSource), typeof(ProxyImage), new PropertyMetadata(null));

        public static readonly DependencyProperty ImageProperty = ImagePropertyKey.DependencyProperty;


        protected override Freezable CreateInstanceCore() => new ProxyImage();
    }
}
