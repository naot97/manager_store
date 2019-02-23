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
    public partial class BanHang : Page
    {
        public static Window w2 = new Window();
        public List<Hang> listBan = new List<Hang>();
        double tongTien = 0;
        public static async void LayData()
        {
            Manager.listHang = await App.MobileService.GetTable<Hang>().ToListAsync();
        }
        public BanHang()
        {
            InitializeComponent();
            LayData();
        }

        private void TimKiemButton_Click(object sender, RoutedEventArgs e)
        {
            TimKiemHang tk = new TimKiemHang();
            w2 = new Window();
            w2.Height = 500;
            w2.Content = tk;
            w2.ShowDialog();
            Hang temp = (Hang)tk.listHang.SelectedItem;
            int x;
            if (int.TryParse(tk.SoLuongBox.Text,out x ) == false) temp = null;
            if (temp == null ) return;
            Hang hangduocChon = new Hang()
            {
                ten = temp.ten,
                maHang = temp.maHang,
                soLuong = int.Parse(tk.SoLuongBox.Text),
                donGia = temp.donGia,
                loai = temp.loai,
                id = temp.id,
            };
            listBan.Add(hangduocChon);
            this.DataContext = null;
            this.DataContext = listBan;
            tongTien += hangduocChon.donGia * hangduocChon.soLuong;
            Tong.Text = "Tổng tiền : " + tongTien.ToString() + " VND";
        }

        private void HoaDonButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < listBan.Count;i++)
            {
                var temp = Manager.listHang.Find(r => r.maHang == listBan[i].maHang);
                if (temp != null) App.MobileService.GetTable<Hang>().UpdateAsync(temp);
            }
            MessageBox.Show("In hóa đơn thành công");
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
    }
}
