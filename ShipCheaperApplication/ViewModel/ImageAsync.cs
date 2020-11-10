using Common;
using System;
using System.IO;
using System.Net;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ViewModel
{
    /// <summary>Реализация базового класса асинхронной загрузки
    /// изображения</summary>
    public class ImageAsync : ImageAsyncBase
    {
        /// <summary>Экземпляр конвертера</summary>
        public static ImageSourceConverter ImageSourceConverter { get; }
            = new ImageSourceConverter();


        public override BitmapImage ImageLoad(object uri)
        {
            WebClient wc = new WebClient();

            try
            {
                if (!(uri is Uri uriWeb))
                    uriWeb = new Uri(uri.ToString());

                byte[] imageBytes = wc.DownloadData(uriWeb);

                //Тут он проскакивает
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = ms;
                    bitmapImage.EndInit();
                    return bitmapImage;
                }
            }
            catch
            {

            }
            return null;
        }

    }
}
