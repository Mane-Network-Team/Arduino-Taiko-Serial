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

namespace Mane_Taiko
{
    /// <summary>
    /// Interaction logic for P_Error.xaml
    /// </summary>
    public partial class P_Error : Page
    {
        public P_Error()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManeV.UI_MainFrame.Navigate(new P_Welcome());
        }
    }
}
