using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Model;

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Interaction logic for PicturePostUserControl.xaml
    /// </summary>
    public partial class PicturePostUserControl : UserControl
    {

        public PicturePostUserControl(PicturePostModel picturePostModel)
        {
            InitializeComponent();
            imgPost1.Source = picturePostModel.PostImage;
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            UCPostOperation.ChangeImgLikeIcons();
        }
    }
}
