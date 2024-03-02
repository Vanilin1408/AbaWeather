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
    /// Логика взаимодействия для TopBordersDaysInfo.xaml
    /// </summary>
    public partial class TopBordersDaysInfo : UserControl
    {
        public TopBordersDaysInfo()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty WeekDayTextProperty = DependencyProperty.Register("WeekDayText", typeof(string), typeof(TopBordersDaysInfo), new PropertyMetadata("Пн"));
        public static readonly DependencyProperty DateTextProperty = DependencyProperty.Register("DateText", typeof(string), typeof(TopBordersDaysInfo), new PropertyMetadata("19 февр"));
        public static readonly DependencyProperty TempDayProperty = DependencyProperty.Register("TempDayText", typeof(string), typeof(TopBordersDaysInfo), new PropertyMetadata("+5°"));
        public static readonly DependencyProperty TempNightProperty = DependencyProperty.Register("TempNightText", typeof(string), typeof(TopBordersDaysInfo), new PropertyMetadata("+1°"));
        public static readonly DependencyProperty DescriptionTextProperty = DependencyProperty.Register("DescriptionText", typeof(string), typeof(TopBordersDaysInfo), new PropertyMetadata("Облачно с прояснениями"));

        public string WeekDayText
        {
            get { return (string)GetValue(WeekDayTextProperty); }
            set { SetValue(WeekDayTextProperty, value); }
        }

        public string DateText
        {
            get { return(string)GetValue(DateTextProperty); } 
            set { SetValue(DateTextProperty, value); }
        }
        
        public string TempDayText
        {
            get { return (string)GetValue(TempDayProperty); }
            set { SetValue(TempDayProperty, value); }
        }

        public string TempNightText
        {
            get { return (string)GetValue(TempNightProperty); }
            set { SetValue(TempNightProperty, value); }
        }

        public string DescriptionText
        {
            get { return (string)GetValue(DescriptionTextProperty); }
            set { SetValue(DescriptionTextProperty, value); }
        }
    }
}
