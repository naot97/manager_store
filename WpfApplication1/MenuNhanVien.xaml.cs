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
    public partial class MenuNhanVien : Page
    {
        public MenuNhanVien()
        {
            InitializeComponent();
        }

        private void TraCuuButton_Click(object sender, RoutedEventArgs e)

        {
            tjin_CHINHSUAHANG xemHang = new tjin_CHINHSUAHANG();
            xemHang.btnSave.Visibility = Visibility.Collapsed;
            xemHang.btnDelete.Visibility = Visibility.Collapsed;
            xemHang.btnThemMoi.Visibility = Visibility.Collapsed;
            xemHang.vanban.IsHitTestVisible = false;
            this.NavigationService.Navigate(xemHang);
        }

        private void BanHangButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BanHang());
        }
    }
}
