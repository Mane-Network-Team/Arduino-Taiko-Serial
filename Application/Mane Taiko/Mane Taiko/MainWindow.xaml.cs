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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace Mane_Taiko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ManeV.UI_MainFrame = this.UI_MainFrame;
        }

        private void Change_Language_Click(object sender, RoutedEventArgs e)
        {
            ManeV.Language = UI_Lang_BTN.Content.ToString();
            UI_Lang_BTN.Content = ManeV.Language == "EN" ? "ZH" : "EN";
            List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
            foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
            {
                dictionaryList.Add(dictionary);
            }
            string requestedCulture = @"pack://application:,,,/Mane_"+ ManeV.Language + ".xaml";
            ResourceDictionary resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture));
            Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
        private void Frame_Ani()
        {
            ThicknessAnimation FrameAnimate= new ThicknessAnimation();
            FrameAnimate.From = new Thickness(200, 0, 0, 0);
            FrameAnimate.To = new Thickness(0, 0, 0, 0);
            FrameAnimate.Duration = new Duration(TimeSpan.FromSeconds(1));
            IEasingFunction Easingfun = new CubicEase()
            {
                EasingMode = EasingMode.EaseOut
            };
            FrameAnimate.EasingFunction = Easingfun;
            UI_MainFrame.BeginAnimation(Frame.MarginProperty, FrameAnimate);

        }
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            P_Welcome p = new P_Welcome();
            UI_MainFrame.Navigate(p);

        }

        private void UI_MainFrame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            Frame_Ani();

        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
