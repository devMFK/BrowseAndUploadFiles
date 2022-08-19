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

namespace BrowseAndUploadFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            bool? response = openFileDialog.ShowDialog(); // bool? response = null (kısa kullanımı)
            if(response == true)
            {
                string dosyaYolu = openFileDialog.FileName;
                string dosyaTuru = System.IO.Path.GetExtension(dosyaYolu);
                uploadedFileLabel.Content = "Dosya yolu: " + dosyaYolu;
                uploadedFileExtension.Content = "Dosya Türü " + dosyaTuru;
            }
            else
            {
                uploadedFileLabel.Content = "";
                uploadedFileExtension.Content = "";
            }
        }
    }
}
