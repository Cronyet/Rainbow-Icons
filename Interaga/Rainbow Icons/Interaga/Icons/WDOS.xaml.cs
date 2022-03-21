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

namespace Interaga.Icons
{
    /// <summary>
    /// WDOS.xaml 的交互逻辑
    /// </summary>
    public partial class WDOS : UserControl
    {
        public WDOS()
        {
            InitializeComponent();
        }
        public LinearGradientBrush ThemeColor
        {
            get { return (LinearGradientBrush)GetValue(ThemeColorProperty); }
            set { SetValue(ThemeColorProperty, value); }
        }

        public static readonly DependencyProperty ThemeColorProperty =
            DependencyProperty.Register("ThemeColor", typeof(LinearGradientBrush), typeof(WDOS),
                new PropertyMetadata(new LinearGradientBrush(Color.FromArgb(255, 27, 27, 27),
                    Color.FromArgb(255, 00, 26, 61), new Point(0, 0), new Point(1, 1))));
    }
}
