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
    public partial class TinhLuong : Page
    {
        NhanVien NhanVienDuocLuong;
        public TinhLuong()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            searchBox.Text = "";
            searchBox.GotFocus -= TextBox_GotFocus;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var temp = Manager.listNV.Find(a => a.maNV.ToLower() == searchBox.Text.ToLower() || a.hoTen.ToLower().Contains(searchBox.Text.ToLower()));
            if (temp == null) return;
            HoTenBox.Text = temp.hoTen;
            MaSoBox.Text = temp.maNV;
            NamSinhBox.Text = temp.namSinh.ToString();
            NgayLamBox.Text = temp.ngayDiLam.ToString();
            DVLBox.Text = temp.donViLuong.ToString();
            Luong.Text = "Lương: " +(temp.ngayDiLam * temp.donViLuong).ToString();
            Bang.Visibility = Visibility.Visible;
            NhanVienDuocLuong = temp;
        }
        private void LapHoaDon_Click(object sender, RoutedEventArgs e)
        {
            NhanVienDuocLuong.ngayDiLam = 0;
            App.MobileService.GetTable<NhanVien>().UpdateAsync(NhanVienDuocLuong);
            MessageBox.Show("In hoá đơn thành công");
        }
    }
}
