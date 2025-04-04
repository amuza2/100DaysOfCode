using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfApp1.UserControls
{
/// <summary>
    /// Interaction logic for PostOperationsUserControle.xaml
/// </summary>
public partial class PostOperationsUserControle : UserControl
{
    public bool IsLiked { get; set; } = false;
    public PostOperationsUserControle()
    {
    InitializeComponent();
    }
    public void ChangeImgLikeIcons()
    {
    if (IsLiked)
    {
    imgHeart.Source = new BitmapImage(
    new Uri("pack://application:,,,/Icons/heart_black.png", UriKind.Absolute)
    );
    }
    else
    {
    imgHeart.Source = new BitmapImage(
    new Uri("pack://application:,,,/Icons/heart_red.png", UriKind.Absolute)
    );
    }

    IsLiked = !IsLiked;
    }

    private void imgHeart_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
    ChangeImgLikeIcons();
    }

    }
}
