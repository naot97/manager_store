using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.WindowsAzure.MobileServices;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for HangHoa.xaml
    /// </summary>
    public partial class ChinhSuaHang : Page
    {
        public ChinhSuaHang()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Search_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = "";
            SearchBox.GotFocus -= Search_GotFocus;
            SearchBox.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            ChitietHang.Visibility = Visibility.Visible;
        }

        private void SreachButton_Click(object sender, RoutedEventArgs e)
        { 
        }

        private void XoaButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

