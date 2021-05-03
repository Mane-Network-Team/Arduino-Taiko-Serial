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
using System.Threading;
using System.Runtime.InteropServices;

namespace Mane_Taiko
{
    /// <summary>
    /// Interaction logic for P_Main.xaml
    /// </summary>
    public partial class P_Main : Page
    {
        Thread check_thread;
        public P_Main()
        {
            InitializeComponent();
        }

        private void SettingBTN_Click(object sender, RoutedEventArgs e)
        {
            Stop_All();
            ManeV.UI_MainFrame.Navigate(new P_Setting());
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ManeV.USB.serial_port = new SerialPort();
                ManeV.USB.serial_port.PortName = ManeV.USB.COM;
                ManeV.USB.serial_port.BaudRate = ManeV.USB.Speed;
                ManeV.USB.serial_port.Open();
                ManeV.USB.serial_port.DataReceived += Serial_port_DataReceived; ;

                check_thread = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(100);
                        if (!ManeV.USB.serial_port.IsOpen)
                        {
                            this.Dispatcher.Invoke(new Action(() =>
                            {
                                ManeV.UI_MainFrame.Navigate(new P_Error());
                            }));
                            check_thread.Abort();
                            break;
                        }
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            A_Label.Content = ManeV.Count.A.ToString();
                            B_Label.Content = ManeV.Count.B.ToString();
                            C_Label.Content = ManeV.Count.C.ToString();
                            D_Label.Content = ManeV.Count.D.ToString();
                        }));
                    }
                });
                check_thread.Start();
            }
            catch
            {
                if (!ManeV.USB.serial_port.IsOpen)
                {
                    ManeV.USB.serial_port.Dispose();
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        ManeV.UI_MainFrame.Navigate(new P_Error());
                    }));
                }
            }
        }

        private void Serial_port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string ReadLines = ManeV.USB.serial_port.ReadLine().Trim();
                switch (ReadLines)
                {
                    case "M":
                        ManeV.Count.A++;
                        System.Windows.Forms.SendKeys.SendWait(((char)ManeV.Keys.ACode).ToString());
                        break;
                    case "A":
                        ManeV.Count.B++;
                        System.Windows.Forms.SendKeys.SendWait(((char)ManeV.Keys.BCode).ToString());
                        break;
                    case "N":
                        ManeV.Count.C++;
                        System.Windows.Forms.SendKeys.SendWait(((char)ManeV.Keys.CCode).ToString());

                        break;
                    case "E":
                        ManeV.Count.D++;
                        System.Windows.Forms.SendKeys.SendWait(((char)ManeV.Keys.DCode).ToString());

                        break;
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

        private void Stop_All()
        {
            try
            {
                check_thread.Abort();
            }
            catch { }

            if (ManeV.USB.serial_port.IsOpen)
            {
                ManeV.USB.serial_port.DiscardInBuffer();
                ManeV.USB.serial_port.DiscardOutBuffer();
                ManeV.USB.serial_port.Close();
                ManeV.USB.serial_port.Dispose();
            }
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            Stop_All();
        }

        private void RST_BTN_Click(object sender, RoutedEventArgs e)
        {
            Stop_All();
            ManeV.UI_MainFrame.Navigate(new P_Welcome());

        }
    }
}
