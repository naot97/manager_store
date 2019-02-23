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
    /// Interaction logic for MenuManager.xaml
    /// </summary>
    public partial class MenuManager : Page
    {
        public MenuManager()
        {
            InitializeComponent();
        }

        private void TinhLuongButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TinhLuong());
        }

        private void DiemDanhButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DiemDanh());
        }

        private void SuaNVButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new tjin_NHANSU());
        }

        private void SuaHangButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new tjin_CHINHSUAHANG());

        }

        private void DoiPassButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ChangePass());

        }
    }
}
