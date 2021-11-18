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

namespace WebImageViewer
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage myBitmapImage = new BitmapImage();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            //wb.Navigate(new Uri(tb.Text));
            //<WebBrowser x:Name="wb" Margin="0,41,-0.4,0"/>
            
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(tb.Text);
            myBitmapImage.EndInit();
            myImage.Source = myBitmapImage;
        }
    }
}
