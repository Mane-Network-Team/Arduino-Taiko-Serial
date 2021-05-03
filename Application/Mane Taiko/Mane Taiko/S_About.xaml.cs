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
    /// Interaction logic for S_About.xaml
    /// </summary>
    public partial class S_About : Page
    {
        public S_About()
        {
            InitializeComponent();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try { System.Diagnostics.Process.Start("https://manesec.blogspot.com/"); }
            catch { }
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            try { System.Diagnostics.Process.Start("https://manesec.com/"); }
            catch { }
        }
    }
}
