using System.Windows.Controls;
using WpfApp1.Model;

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Interaction logic for VideoPostUserControl.xaml
    /// </summary>
    public partial class VideoPostUserControl : UserControl
    {
        public VideoPostUserControl(VideoPostModel videoPostModel)
        {
            InitializeComponent();
            meVideo.Source = videoPostModel.VideoUri;
        }

        private void UserControl_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            UCPostOperation.ChangeImgLikeIcons();
        }
    }
}
