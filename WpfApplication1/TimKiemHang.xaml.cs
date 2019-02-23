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
    public partial class TimKiemHang : Page
    {
        public TimKiemHang()
        {
            InitializeComponent();
            this.DataContext = Manager.listHang;
        }

        private void SoLuongBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SoLuongBox.Text = "";
            SoLuongBox.GotFocus -= SoLuongBox_GotFocus;
            SoLuongBox.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = "";
            SearchBox.GotFocus -= SearchBox_GotFocus;
            SearchBox.Foreground = new SolidColorBrush(Colors.Black); 
        }
        private void HienThiHangDuocChon(Hang hangDuocChon)
        {
            Result.Text = string.Format("Tên: {0} \nMã hàng : {1} \nLoại : {2} \nSố lượng : {3}\nĐơn giá : {4}",hangDuocChon.ten, hangDuocChon.maHang, hangDuocChon.loai,
            hangDuocChon.soLuong, hangDuocChon.donGia);
            imgR.Source = new BitmapImage(new Uri(hangDuocChon.sourceAnh, UriKind.RelativeOrAbsolute));
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var hangDuocChon = Manager.listHang.Find(r => r.ten.ToLower().Contains( SearchBox.Text.ToLower()) || r.maHang.ToLower() == SearchBox.Text.ToLower());
            if (hangDuocChon != null)
            {
                listHang.SelectedItem = hangDuocChon;
                HienThiHangDuocChon(hangDuocChon);
            }
        }
        private void listHang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HienThiHangDuocChon((Hang)e.AddedItems[0]);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            bool coLoi = false;
            int soluong = 0;
            try
            {
                if (listHang.SelectedItem == null) throw new Exception();
                soluong = int.Parse(SoLuongBox.Text);
                if (soluong > ((Hang)listHang.SelectedItem).soLuong || soluong <= 0 ) throw new Exception();
            }
            catch
            {
                coLoi = true;
                MessageBox.Show("Bạn chưa chọn hàng hoặc nhập không đúng số lượng");
            }
            if (!coLoi)
            {
                Manager.listHang.Find(r => r.maHang == ((Hang)listHang.SelectedItem).maHang).soLuong -= soluong;
                this.DataContext = Manager.listHang;
                BanHang.w2.Close();
            }
        }
    }
}
