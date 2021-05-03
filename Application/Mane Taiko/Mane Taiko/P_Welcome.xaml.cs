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
using System.Threading;

namespace Mane_Taiko
{
    /// <summary>
    /// Interaction logic for P_Welcome.xaml
    /// </summary>
    public partial class P_Welcome : Page
    {
        
        public P_Welcome()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Thread T = new Thread(() => {
                for (int x = 0; x<= 3; x++)
                {
                    Thread.Sleep(1000);
                }
                this.Dispatcher.Invoke(new Action(() =>
                {
                    ManeV.UI_MainFrame.Navigate(new P_ConnectDevices());
                }));
            });
            T.Start();
        }
    }
}
