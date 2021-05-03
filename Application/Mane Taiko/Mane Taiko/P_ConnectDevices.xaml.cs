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
using System.IO.Ports;

namespace Mane_Taiko
{
    /// <summary>
    /// Interaction logic for P_ConnectDevices.xaml
    /// </summary>
    public partial class P_ConnectDevices : Page
    {
        public P_ConnectDevices()
        {
            InitializeComponent();
        }

        private void GetCOM()
        {
            NextBTN.IsEnabled = false;
            COM_LIST.Items.Clear();
            foreach(string x in SerialPort.GetPortNames())
            {
                ComboBoxItem i = new ComboBoxItem();
                i.Content = x;
                COM_LIST.Items.Add(i);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetCOM();
        }

        private void COM_LIST_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox s = (ComboBox)sender;
            NextBTN.IsEnabled = (s.Text.Trim() == "") ? false : true;
        }

        private void NextBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SerialPort testing = new SerialPort();
                testing.PortName = COM_LIST.Text;
                testing.BaudRate = int.Parse(Speed_List.Text);
                testing.Open();
                testing.Close();
                testing.Dispose();

                ManeV.USB.COM = COM_LIST.Text;
                ManeV.USB.Speed = int.Parse(Speed_List.Text);
                ManeV.UI_MainFrame.Navigate(new P_RST());
            }
            catch
            {
                NextBTN.Content = "Failed ! Please try again";
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetCOM();
        }
    }
}
