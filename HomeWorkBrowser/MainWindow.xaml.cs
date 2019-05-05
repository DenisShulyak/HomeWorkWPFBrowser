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
using static System.Net.WebRequestMethods;

namespace HomeWorkBrowser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int countTabs = 1;
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Thickness thickness = new Thickness
            {
                Left =27 + countTabs*12,
               Top = 10
            };
            countTabs++;
            buttonPlus.Margin = thickness;    
            Uri uri = new Uri(@"https://www.google.com/search?q=");
           browserControl.Items.Add(new WebBrowser { Source = uri });
            
        }
    }
}

