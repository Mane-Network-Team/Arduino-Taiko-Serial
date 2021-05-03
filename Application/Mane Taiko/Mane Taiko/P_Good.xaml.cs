using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for P_Good.xaml
    /// </summary>
    public partial class P_Good : Page
    {
        public P_Good()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Thread T = new Thread(() => {
                for (int x = 0; x <= 2; x++)
                {
                    Thread.Sleep(1000);
                }
                this.Dispatcher.Invoke(new Action(() =>
                {
                    ManeV.UI_MainFrame.Navigate(new P_Main());
                }));
            });
            T.Start();
        }
    }
}
