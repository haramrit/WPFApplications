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

namespace BinaryResourcesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<BitmapImage> _images = new List<BitmapImage>();
        private int _currImage = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string path = Environment.CurrentDirectory;
                _images.Add(new BitmapImage(new Uri($@"Images\file (1).png", UriKind.Relative)));
                _images.Add(new BitmapImage(new Uri($@"Images\folder-closed (1).png", UriKind.Relative)));
                _images.Add(new BitmapImage(new Uri($@"Images\folder-open (1).png", UriKind.Relative)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPreviousImage_Click(object sender, RoutedEventArgs e)
        {
            if (--_currImage < 0)
            {
                _currImage = _images.Count - 1;
            }
            imageHolder.Source = _images[_currImage];
        }

        private void btnNextImage_Click(object sender, RoutedEventArgs e)
        {
            if (++_currImage >= _images.Count)
            {
                _currImage = 0;
            }
            imageHolder.Source = _images[_currImage];
        }


    }
}
