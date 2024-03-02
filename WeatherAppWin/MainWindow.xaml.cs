using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherAppWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenLeftSideGrid_Click(object sender, RoutedEventArgs e)
        {
            var path = OpenLeftSideGrid.Template.FindName("PathOfButton", OpenLeftSideGrid) as Path;
            var widthAnimation = new DoubleAnimation();
            widthAnimation.Duration = TimeSpan.FromSeconds(0.2);

            if (leftSideMainGrid.Width > 20)
            {
                widthAnimation.From = 220;
                widthAnimation.To = 20;

                leftSideMainGrid.BeginAnimation(Grid.WidthProperty, widthAnimation);

                if (path != null)
                {
                    path.Data = Geometry.Parse("M 5,0 L 15,10 L 5, 20");
                }
            }
            else
            {
                widthAnimation.From = 20;
                widthAnimation.To = 220;

                leftSideMainGrid.BeginAnimation(Grid.WidthProperty, widthAnimation);

                if (path != null)
                {
                    path.Data = Geometry.Parse("M 15,0 L 5,10 L 15,20");
                }
            }

        }


    }
}