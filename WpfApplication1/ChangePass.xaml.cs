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
    public partial class ChangePass : Page
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        
        private string _NewPass;
        private string _ReNewPass;
        public int CompareTwoPass(string Newpass, string ReNewpass)
        {
            return _NewPass.CompareTo(_ReNewPass);
        }
        private void XacNhanButton_Click(object sender, RoutedEventArgs e)
        {
            _NewPass = NewPassBox.Password;
            _ReNewPass = ReNewPassBox.Password;
            if (CompareTwoPass(_NewPass, _ReNewPass) == 0 && _NewPass != "")
            {
                DangNhap.listManager[0].matKhau = _NewPass;
                App.MobileService.GetTable<Account>().UpdateAsync(DangNhap.listManager[0]);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else MessageBox.Show("Nhập sai. Mời nhập lại");
        }
    private void NewPassBox_GotFocus(object sender, RoutedEventArgs e)
        {
            NewPassBox.Password = "";
            NewPassBox.GotFocus -= NewPassBox_GotFocus;
        }

        private void ReNewPassBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ReNewPassBox.Password = "";
            ReNewPassBox.GotFocus -= ReNewPassBox_GotFocus;
        }
    }
}
