using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for S_Key.xaml
    /// </summary>
    public partial class S_Key : Page
    {
        public S_Key()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            for (int x = (int)'a';x<= (int)'z'; x++)
            {
                {
                    ComboBoxItem c = new ComboBoxItem();
                    c.Content = (char)x;
                    c.Tag = x;
                    AKEYLIST.Items.Add(c);
                }
                {
                    ComboBoxItem c = new ComboBoxItem();
                    c.Content = (char)x;
                    c.Tag = x;
                    BKEYLIST.Items.Add(c);
                }
                {
                    ComboBoxItem c = new ComboBoxItem();
                    c.Content = (char)x;
                    c.Tag = x;
                    CKEYLIST.Items.Add(c);
                }
                {
                    ComboBoxItem c = new ComboBoxItem();
                    c.Content = (char)x;
                    c.Tag = x;
                    DKEYLIST.Items.Add(c);
                }
            }

            AKEYLIST.SelectedIndex = ManeV.Keys.ACode - 97;
            BKEYLIST.SelectedIndex = ManeV.Keys.BCode - 97;
            CKEYLIST.SelectedIndex = ManeV.Keys.CCode - 97;
            DKEYLIST.SelectedIndex = ManeV.Keys.DCode - 97;
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            ManeV.Keys.ACode = (int)((ComboBoxItem)AKEYLIST.SelectedItem).Tag;
            ManeV.Keys.BCode = (int)((ComboBoxItem)BKEYLIST.SelectedItem).Tag;
            ManeV.Keys.CCode = (int)((ComboBoxItem)CKEYLIST.SelectedItem).Tag;
            ManeV.Keys.DCode = (int)((ComboBoxItem)DKEYLIST.SelectedItem).Tag;
        }
    }
}
