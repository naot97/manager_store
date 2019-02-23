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
    public partial class DangNhap : Page
    {
        static public List<Account> listManager = new List<Account>();
        public async void LayData()
        {
            NhanVien x = new NhanVien(); 
            listManager = await App.MobileService.GetTable<Account>().ToListAsync(); // list manager
            Manager.listNV = await App.MobileService.GetTable<NhanVien>().ToListAsync(); // list nhan vien
            Manager.listHang = await App.MobileService.GetTable<Hang>().ToListAsync(); // list hang
        }
        public DangNhap()
        {
            LayData(); // lay data tu tren mang
            InitializeComponent();
        }
        private void AccBox_GotFocus(object sender, RoutedEventArgs e)
        {
            AccBox.Text = "";
            AccBox.GotFocus -= AccBox_GotFocus;
            AccBox.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void PassBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PassBox.Password = "";
            PassBox.GotFocus -= PassBox_GotFocus;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (listManager.Exists(r => r.matKhau.Equals(PassBox.Password) && r.tenDN.Equals(AccBox.Text))) // nếu tìm được tên đăng nhập và pass của mânger 
                this.NavigationService.Navigate(new MenuManager());
            else
                if (Manager.listNV.Exists(r => r.matKhau.Equals(PassBox.Password) && r.tenDN.Equals(AccBox.Text))) // nếu tìm được tên đăng nhập và pass của mânger 
                this.NavigationService.Navigate(new MenuNhanVien());
            else
                MessageBox.Show("Tên đăng nhập và mật khẩu không đúng. Mời nhập lại");
        }
    }
}
