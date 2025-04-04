using System.IO;
using System.Windows.Media.Imaging;

namespace WpfApp1.Database
{
    public class MockDB
    {
        public static Uri GetVideoUri()
        {
            string videoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Video", "Facebook.mp4");
            return new Uri(videoPath, UriKind.Absolute);
        }

        public static BitmapImage GetImageBitmap()
        {
            string rootProjectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string imagespath = Path.Combine(rootProjectDir, "Images");

            List<string> imagesPaths = new[] {"*.jpeg", "*.jpg"}
                        .SelectMany(ext => Directory.GetFiles(imagespath, ext))
                        .ToList();

            Random random = new Random(DateTime.Now.Millisecond);
            FileInfo randomImages = new FileInfo(imagesPaths[random.Next(imagesPaths.Count)]);

            return new BitmapImage(new Uri(randomImages.FullName, UriKind.RelativeOrAbsolute));
        }
    }
}