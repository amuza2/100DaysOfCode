using System.Windows;
using WpfApp1.Model;
using WpfApp1.UserControls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainSocialWindow.xaml
    /// </summary>
    public partial class MainSocialWindow : Window
    {
        public MainSocialWindow()
        {
            InitializeComponent();
            spMain.Children.Add(new VideoPostUserControl(new VideoPostModel()));
            spMain.Children.Add(new PicturePostUserControl(new PicturePostModel()));
            spMain.Children.Add(new VideoPostUserControl(new VideoPostModel()));
            spMain.Children.Add(new PicturePostUserControl(new PicturePostModel()));
        }

        private void MainScrollView_ScrollChanged(object sender, System.Windows.Controls.ScrollChangedEventArgs e)
        {
            if(e.VerticalChange > 0)
            {
                int adjustment = 400;
                if(e.VerticalOffset + e.ViewportHeight + adjustment >= e.ExtentHeight)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        PicturePostUserControl picturePost = new PicturePostUserControl(new PicturePostModel());
                        spMain.Children.Add(picturePost);
                    }
                }
            }
        }
    }
}
