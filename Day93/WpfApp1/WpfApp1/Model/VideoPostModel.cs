using WpfApp1.Database;

namespace WpfApp1.Model
{
    public class VideoPostModel
    {
		private Uri? _videoUri;

		public Uri VideoUri
		{
			get 
			{
				if (_videoUri == null)
					_videoUri = MockDB.GetVideoUri();
                else
                {
                    return _videoUri;
                }
                return _videoUri; 
			}
			set { _videoUri = value; }
		}
	}
}
