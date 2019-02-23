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
    public partial class DiemDanh : Page
    {
        public DiemDanh()
        {
            InitializeComponent();
            this.DataContext = Manager.listNV;
        }

        private void DiemDanhButton_Click(object sender, RoutedEventArgs e)
        {
            var temp = listNV.SelectedItems;
            for (int i = 0; i < temp.Count; i++)
            {
                ((NhanVien)temp[i]).ngayDiLam++;
                App.MobileService.GetTable<NhanVien>().UpdateAsync( (NhanVien)temp[i]);
            }
            MessageBox.Show("Điểm danh thành công");
        }

        private void listNV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TongBox.Text =  "Tổng điểm danh : " + e.AddedItems.Count.ToString();
        }
    }
}
