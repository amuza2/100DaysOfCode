using System.Windows.Media.Imaging;
using WpfApp1.Database;

namespace WpfApp1.Model
{
    public class PicturePostModel
    {
		private BitmapImage _PostImage;

		public BitmapImage PostImage
		{
			get 
			{
				if (_PostImage == null) _PostImage = MockDB.GetImageBitmap();
				return _PostImage;
			}
			set { _PostImage = value; }
		}

	}
}
