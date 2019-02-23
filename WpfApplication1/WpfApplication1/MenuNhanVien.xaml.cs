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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class MenuNhanVien : Page
    {
        public MenuNhanVien()
        {
            InitializeComponent();
        }

        private void TraCuuButton_Click(object sender, RoutedEventArgs e)

        {
            ChinhSuaHang xemHang = new ChinhSuaHang();
            xemHang.newButton.Visibility = Visibility.Collapsed;
            xemHang.XoaButton.Visibility = Visibility.Collapsed;
            xemHang.ChitietHang.IsEnabled = false;
            this.NavigationService.Navigate(xemHang);
            
        }

        private void BanHangButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BanHang());
        }
    }
}
