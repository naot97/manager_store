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
    public partial class tjin_CHINHSUAHANG : Page
    {
        enum TrangThai { themMoi, chinhSua };
        static TrangThai trangThai;
        static Hang hang;
        private void HienThiAnh(string source)
        {
            BitmapImage bm = new BitmapImage(new Uri(source, UriKind.RelativeOrAbsolute));
            Anh.Source = bm;
        }
        public tjin_CHINHSUAHANG()
        {
            InitializeComponent();
            anCacMuc();
        }

        private void anCacMuc()
        {
            //btnDelete.IsEnabled = false;
            //btnSave.IsEnabled = false;


            //lblAnh.IsEnabled = false;
            //lblDonGia.IsEnabled = false;
            //lblLoai.IsEnabled = false;
            //lblMaHang.IsEnabled = false;
            //lblName.IsEnabled = false;
            //lblSoLuong.IsEnabled = false;
            //txtDonGia.IsEnabled = false;
            //txtLoai.IsEnabled = false;
            //txtMaHang.IsEnabled = false;
            //txtName.IsEnabled = false;
            //txtSearch.IsEnabled = false;
            //txtSoLuong.IsEnabled = false;
            vanban.IsEnabled = false;
        }
        private void moCacMuc()
        {
            //btnDelete.IsEnabled = true;
            //btnSave.IsEnabled = true;
            //lblAnh.IsEnabled = true;
            //lblDonGia.IsEnabled = true;
            //lblLoai.IsEnabled = true;
            //lblMaHang.IsEnabled = true;
            //lblName.IsEnabled = true;
            //lblSoLuong.IsEnabled = true;

            //txtDonGia.IsEnabled = true;
            //txtLoai.IsEnabled = true;
            //txtMaHang.IsEnabled = true;
            //txtName.IsEnabled = true;
            //txtSearch.IsEnabled = true;
            //txtSoLuong.IsEnabled = true;
            vanban.IsEnabled = true;
        }
       
        private void reset()
        {
            txtDonGia.Text = txtLoai.Text = txtMaHang.Text = txtName.Text = txtSoLuong.Text = "";
            hang = null;
            moCacMuc();
            trangThai = TrangThai.themMoi;
        }

        private void    createHang()
        {
            if (Manager.listHang.Exists(r => r.maHang.ToLower().Equals(txtMaHang.Text.ToLower())))
            {
                MessageBox.Show("Mã số bạn nhập đã tồn tại !", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaHang.Focus();
                return;
            }

            if (Manager.listHang.Exists(r => r.ten.ToLower().Equals(txtName.Text.ToLower())))
            {
                MessageBox.Show("Tên hàng bạn nhập đã có tồn tại!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtName.Focus();
                return;
            }
            Hang HANG = new Hang();
            try
            {
                HANG.ten = txtName.Text;
                HANG.loai = txtLoai.Text;
                HANG.maHang = txtMaHang.Text;
                HANG.sourceAnh = txtAnh.Text;
                HANG.soLuong = int.Parse(txtSoLuong.Text);
                HANG.donGia = double.Parse(txtDonGia.Text);
            }
            catch
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Manager.listHang.Add(HANG);
            App.MobileService.GetTable<Hang>().InsertAsync(HANG);
            MessageBox.Show("Tạo thành công !", "Successfull!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            reset();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                reset();
                anCacMuc();
                return;
            }
            
            var temp = Manager.listHang.Find(x => x.ten.ToLower().Contains(txtSearch.Text.ToLower()) || x.maHang.ToLower() == txtSearch.Text.ToLower());
            hang = temp;
            if ( hang == null )
            {
                hang = Manager.listHang.Find(x => x.maHang.Contains(txtSearch.Text));
            }

            if ( hang != null )
            {
                moCacMuc();

                txtDonGia.Text = hang.donGia.ToString();
                txtLoai.Text = hang.loai;
                txtMaHang.Text = hang.maHang;
                txtName.Text = hang.ten;
                txtSoLuong.Text = hang.soLuong.ToString();
                txtAnh.Text = hang.sourceAnh;
                HienThiAnh(txtAnh.Text);
                trangThai = TrangThai.chinhSua;
            }
        }

        private void Search_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSearch.Opacity = 1;
            txtSearch.Text = "";
            txtSearch.GotFocus -= Search_GotFocus;
            txtSearch.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtName.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtLoai.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLoai.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaHang.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtDonGia.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSoLuong.Focus();
                return;
            }

            if (trangThai == TrangThai.themMoi)
            {
                createHang();
            }
            else
            {
                try
                {
                    hang.ten = txtName.Text;
                    hang.loai = txtLoai.Text;
                    hang.maHang = txtMaHang.Text;
                    hang.sourceAnh = txtAnh.Text;
                    hang.soLuong = int.Parse(txtSoLuong.Text);
                    hang.donGia = double.Parse(txtDonGia.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập sai kiểu dữ liệu", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSoLuong.Focus();
                    return;
                }
                App.MobileService.GetTable<Hang>().UpdateAsync(hang);
                MessageBox.Show("Chỉnh sửa thành công !", "Successfull", MessageBoxButton.OK, MessageBoxImage.Asterisk);

            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (trangThai == TrangThai.themMoi)  //  Them moi
            {
                reset();
            }
            else //     Chinh sua Hang da co, cap nhat thong tin
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Lựa chọn", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    App.MobileService.GetTable<Hang>().DeleteAsync(hang);
                    Manager.listHang.Remove(hang);
                    reset();
                    MessageBox.Show("Đã xóa thành công!", "Successfull", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
            }
        }

        private void btnThemMoi_Click(object sender, RoutedEventArgs e)
        {
            reset();
            moCacMuc();
            hang = null;
        }

        private void pageChinhSuaHang_Loaded(object sender, RoutedEventArgs e)
        {
            reset();
            anCacMuc();
        }


        private void txtAnh_TextChanged(object sender, TextChangedEventArgs e)
        {
            HienThiAnh(txtAnh.Text);
        }
    }
}
