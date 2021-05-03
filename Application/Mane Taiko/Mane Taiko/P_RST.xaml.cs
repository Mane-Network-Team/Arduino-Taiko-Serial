using System;
using System.Collections.Generic;
using System.IO.Ports;
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
    /// Interaction logic for P_RST.xaml
    /// </summary>
    public partial class P_RST : Page
    {
        public P_RST()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            check_thread.Abort();
            if (ManeV.USB.serial_port.IsOpen)
            {
                ManeV.USB.serial_port.Close();
                ManeV.USB.serial_port.Dispose();
            }

            ManeV.UI_MainFrame.Navigate(new P_ConnectDevices());
        }

        Thread check_thread;
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ManeV.USB.serial_port = new SerialPort();
                ManeV.USB.serial_port.PortName = ManeV.USB.COM;
                ManeV.USB.serial_port.BaudRate = ManeV.USB.Speed;
                ManeV.USB.serial_port.Open();
                ManeV.USB.serial_port.DataReceived += Serial_port_DataReceived;

                check_thread =  new Thread(() =>
                {
                   while (true)
                   {
                        Thread.Sleep(100);
                        if (!ManeV.USB.serial_port.IsOpen){
                            this.Dispatcher.Invoke(new Action(()=>
                            {
                                ManeV.UI_MainFrame.Navigate(new P_Error());
                            }));
                            check_thread.Abort();
                            break;
                        }
                    }
                });
                check_thread.Start();
            }
            catch
            {
                Console.WriteLine("Error");
                ManeV.USB.serial_port.Close();
                ManeV.USB.serial_port.Dispose();
            }
        }


        private void Serial_port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (ManeV.USB.serial_port.ReadLine().Trim() == "MANE_TAIKO_DEMO")
                {
                    check_thread.Abort();
                    ManeV.USB.serial_port.DiscardInBuffer();
                    ManeV.USB.serial_port.DiscardOutBuffer();
                    ManeV.USB.serial_port.Close();
                    ManeV.USB.serial_port.Dispose();

                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        ManeV.UI_MainFrame.Navigate(new P_TestKey());
                    }));
                }
            }
            catch
            {
                if (ManeV.USB.serial_port.IsOpen)
                {
                    ManeV.USB.serial_port.DiscardInBuffer();
                    ManeV.USB.serial_port.DiscardOutBuffer();
                }
            }

        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            check_thread.Abort();
        }
    }
}
