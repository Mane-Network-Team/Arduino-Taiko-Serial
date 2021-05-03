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
    /// Interaction logic for P_Setting.xaml
    /// </summary>
    public partial class P_Setting : Page
    {
        public P_Setting()
        {
            InitializeComponent();
        }

        S_About s_About = new S_About();
        S_Key s_Key = new S_Key();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SettingFrame.Navigate(s_Key);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SettingFrame.Navigate(s_About);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ManeV.UI_MainFrame.Navigate(new P_Main());
        }
    }
}
