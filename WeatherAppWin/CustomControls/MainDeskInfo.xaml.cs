using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherAppWin.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для MainDeskInfo.xaml
    /// </summary>
    public partial class MainDeskInfo : UserControl
    {
        public MainDeskInfo()
        {
            InitializeComponent();
        }

        // 1 column
        public static readonly DependencyProperty TodayMainTempProperty = DependencyProperty.Register("TodayMainTemp", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));
        public static readonly DependencyProperty TodayDescriptionProperty = DependencyProperty.Register("TodayDescription", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));
        public static readonly DependencyProperty UnderTodayDescriptionProperty = DependencyProperty.Register("UnderTodayDescription", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));
        // 2 column
        public static readonly DependencyProperty WindInfoProperty = DependencyProperty.Register("WindInfo", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));
        public static readonly DependencyProperty HumidityInfoProperty = DependencyProperty.Register("HumidityInfo", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));
        public static readonly DependencyProperty PressureInfoProperty = DependencyProperty.Register("PressureInfo", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));
        public static readonly DependencyProperty UFindexInfoProperty = DependencyProperty.Register("UFindexInfo", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));
        // 3 column
        public static readonly DependencyProperty LenSunDayInfoProperty = DependencyProperty.Register("LenSunDayInfo", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));
        public static readonly DependencyProperty SunRiseTimeProperty = DependencyProperty.Register("SunRiseTime", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));
        public static readonly DependencyProperty SunSetTimeProperty = DependencyProperty.Register("SunSetTime", typeof(string), typeof(MainDeskInfo), new PropertyMetadata("--"));

        public string TodayMainTemp
        {
            get { return (string)GetValue(TodayMainTempProperty); }
            set { SetValue(TodayMainTempProperty, value); }
        }

        public string TodayDescription
        {
            get { return (string)GetValue(TodayDescriptionProperty); }
            set { SetValue(TodayDescriptionProperty, value); }
        }

        public string UnderTodayDescription
        {
            get { return (string)GetValue(UnderTodayDescriptionProperty); }
            set { SetValue(UnderTodayDescriptionProperty, value); }
        }

        public string WindInfo
        {
            get { return (string)GetValue(WindInfoProperty); }
            set { SetValue(WindInfoProperty, value); }
        }

        public string HumidityInfo
        {
            get { return (string)GetValue(HumidityInfoProperty); }
            set { SetValue(HumidityInfoProperty, value); }
        }

        public string PressureInfo
        {
            get { return (string)GetValue(PressureInfoProperty); }
            set { SetValue(PressureInfoProperty, value); }
        }

        public string UFindexInfo
        {
            get { return (string)GetValue(UFindexInfoProperty); }
            set { SetValue(UFindexInfoProperty, value); }
        }

        public string LenSunDayInfo
        {
            get { return (string)GetValue(LenSunDayInfoProperty); }
            set { SetValue(LenSunDayInfoProperty, value); }
        }

        public string SunRiseTime
        {
            get { return (string)GetValue(SunRiseTimeProperty); }
            set { SetValue(SunRiseTimeProperty, value); }
        }

        public string SunSetTime
        {
            get { return (string)GetValue(SunSetTimeProperty); }
            set { SetValue(SunSetTimeProperty, value); }
        }
    }
}
