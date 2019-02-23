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
    /// Interaction logic for ChangePass.xaml
    /// </summary>
    public partial class ChangePass : Page
    {
        public ChangePass()
        {
            InitializeComponent();
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
