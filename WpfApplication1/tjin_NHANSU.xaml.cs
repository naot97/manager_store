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
    /// Interaction logic for tjin_NHANSU.xaml
    /// </summary>
    /// 

    public partial class tjin_NHANSU : Page
    {
        enum TrangThai { themMoi, ChinhSua };
        static TrangThai trangThai ;
        static NhanVien nv;
        public tjin_NHANSU()
        {
            InitializeComponent();
        }
        private void pageNhanSu_Loaded(object sender, RoutedEventArgs e)
        {
            anCacMuc();
            trangThai = TrangThai.themMoi;
            nv = null;
        }

        private void anCacMuc()
        {
            //lblDonViTien.IsEnabled = false;
            //lblMaSo.IsEnabled = false;
            //lblName.IsEnabled = false;
            //lblNgaySinh.IsEnabled = false;
            //lblPass1.IsEnabled = false;
            //lblPass2.IsEnabled = false;
            //lblSDT.IsEnabled = false;
            //lblUser.IsEnabled = false;

            //txtDonViTien.IsEnabled = false;
            //txtMaSo.IsEnabled = false;
            //txtName.IsEnabled = false;
            //txtNamSinh.IsEnabled = false;
            //txtPass1.IsEnabled = false;
            //txtPass2.IsEnabled = false;
            //txtSDT.IsEnabled = false;
            //txtUser.IsEnabled = false;

            vbLable.IsEnabled = false;
            vbTXT.IsEnabled = false;

            btnSave.IsEnabled = false;
            btnDelete.IsEnabled = false;
        }

        private void moCacMuc()
        {
            //lblDonViTien.IsEnabled = true;
            //lblMaSo.IsEnabled = true;
            //lblName.IsEnabled = true;
            //lblNgaySinh.IsEnabled = true;
            //lblPass1.IsEnabled = true;
            //lblPass2.IsEnabled = true;
            //lblSDT.IsEnabled = true;
            //lblUser.IsEnabled = true;

            //txtDonViTien.IsEnabled = true;
            //txtMaSo.IsEnabled = true;
            //txtName.IsEnabled = true;
            //txtNamSinh.IsEnabled = true;
            //txtPass1.IsEnabled = true;
            //txtPass2.IsEnabled = true;
            //txtSDT.IsEnabled = true;
            //txtUser.IsEnabled = true;

            vbLable.IsEnabled = true;
            vbTXT.IsEnabled = true;


            btnSave.IsEnabled = true;
            btnDelete.IsEnabled = true;
        }

        private void reset()
        {
            txtDonViTien.Text = txtMaSo.Text = txtName.Text = txtNamSinh.Text = txtSDT.Text = "";
            txtPass1.Password = txtPass2.Password = txtSDT.Text = txtUser.Text = "";
            anCacMuc();
            trangThai = TrangThai.themMoi;
        }

        public void createNhanVien()
        {
            if (Manager.listNV.Exists(r => r.maNV.ToLower().Equals(txtMaSo.Text.ToLower())))
            {
                MessageBox.Show("Mã số bạn nhập đã tồn tại !", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaSo.Focus();
                return;
            }

            if ( Manager.listNV.Exists(r => r.tenDN.ToLower().Equals(txtUser.Text.ToLower())) )
            {
                MessageBox.Show("Username bạn nhập đã có tồn tại!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtUser.Focus();
                return;
            }
            NhanVien NV = new NhanVien();
            try
            {
                NV.donViLuong = Double.Parse(txtDonViTien.Text);
                NV.hoTen = txtName.Text;
                NV.maNV = txtMaSo.Text;
                NV.namSinh = int.Parse(txtNamSinh.Text);
                NV.soDT = txtSDT.Text;
                NV.tenDN = txtUser.Text;
                NV.matKhau = txtPass1.Password;
                NV.ngayDiLam = 0;
            }
            catch
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Manager.listNV.Add(nv);
            App.MobileService.GetTable<NhanVien>().InsertAsync(nv);
            MessageBox.Show("Tạo thành công !", "Successfull!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            reset();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if ( String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtName.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtMaSo.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaSo.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtNamSinh.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtNamSinh.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtDonViTien.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtDonViTien.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSDT.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtUser.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPass1.Password))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPass1.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPass2.Password))
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPass2.Focus();
                return;
            }

            if ( !txtPass1.Password.Equals(txtPass2.Password) )
            {
                MessageBox.Show("Mật khẩu bạn nhập không trùng nhau! Vui lòng nhập lại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPass1.Focus();
                return;
            }
            else
            {
                if ( trangThai == TrangThai.themMoi )
                {
                    createNhanVien();
                }
                else
                {
                    try
                    {
                        nv.donViLuong = Double.Parse(txtDonViTien.Text);
                        nv.hoTen = txtName.Text;
                        nv.maNV = txtMaSo.Text;
                        nv.namSinh = int.Parse(txtNamSinh.Text);
                        nv.soDT = txtSDT.Text;
                        nv.tenDN = txtUser.Text;
                        nv.matKhau = txtPass1.Password;
                        nv.ngayDiLam = 0;
                    }
                    catch
                    {
                        MessageBox.Show("Nhập sai kiểu dữ liệu", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtNamSinh.Focus();
                        return;
                    }
                    App.MobileService.GetTable<NhanVien>().UpdateAsync(nv);
                   MessageBox.Show("Chỉnh sửa thành công !", "Successfull", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if ( trangThai == TrangThai.themMoi )  //  THem moi
            {
                txtDonViTien.Text = txtMaSo.Text = txtName.Text = txtNamSinh.Text = txtSDT.Text = "";
                txtPass1.Password = txtPass2.Password = txtSDT.Text = txtUser.Text = "";
            }
            else //     Chinh sua Nhan Vien da co, cap nhat thong tin
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Lựa chọn", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    App.MobileService.GetTable<NhanVien>().DeleteAsync(nv);
                    Manager.listNV.Remove(nv);
                    reset();
                    MessageBox.Show("Đã xóa thành công!", "Successfull", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
            }
        }

        private void btnThemMoi_Click(object sender, RoutedEventArgs e)
        {
            reset();
            moCacMuc();
            nv = null;
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if ( String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                reset();
                anCacMuc();
                return;
            }

            nv = Manager.listNV.Find(x => x.hoTen.ToLower().Contains(txtSearch.Text.ToLower()) || x.maNV.ToLower() == txtSearch.Text.ToLower());

            if ( nv == null  )
            {
                nv = Manager.listNV.Find(x => x.hoTen.ToLower().Contains(txtSearch.Text.ToLower()));
            }
 
            if ( nv != null )
            {
                moCacMuc();
                txtName.Text = nv.hoTen;
                txtSDT.Text = nv.soDT;
                txtNamSinh.Text = nv.namSinh.ToString();
                txtMaSo.Text = nv.maNV;
                txtDonViTien.Text = nv.donViLuong.ToString();
                txtUser.Text = nv.tenDN;
                txtPass1.Password = txtPass2.Password = nv.matKhau;

                trangThai = TrangThai.ChinhSua;
            }
            
        }
        private void Search_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.GotFocus -= Search_GotFocus;
            txtSearch.Foreground = new SolidColorBrush(Colors.Black);
            txtSearch.Opacity = 1;
        }

    }
}
