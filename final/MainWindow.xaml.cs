using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;

namespace final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<ArtInfo> artInfos = new ObservableCollection<ArtInfo>();
        string filePath = "";
        string selectedArtStyle = "";

        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<ArtInfo> artInfos = new ObservableCollection<ArtInfo>();
            DateTime date = new DateTime();
            txtDisplay.Text = txtDate.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog files = new OpenFileDialog();

            if (files.ShowDialog() == true)
            {
                filePath = files.FileName;

                lblfilePath.Content = filePath;

                BitmapImage image = new BitmapImage();
                Uri uri = new Uri(filePath);

                image.BeginInit();
                image.UriSource = uri;
                image.EndInit();

                imgDisplay.Source = image;
            }
        }

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.IsChecked == true)
            {
                selectedArtStyle = radioButton.Content.ToString();
            }
        }

        private void btnSumit_Click(object sender, RoutedEventArgs e)
        {
            ArtInfo artInfo = new ArtInfo(txtname.Text, txtDate.Text, txtArtist.Text, selectedArtStyle);

            artInfos.Add(artInfo);
            listView.ItemsSource = artInfos;

            txtDisplay.Text = $"{txtDate.Text}\n{txtname.Text}\n{txtArtist.Text}\n{txtArtInformartion.Text} ";
          //  listView.Items.Add(artInfo);

            RadioButton selectedRadioButton = stackPanel.Children.OfType<RadioButton>().FirstOrDefault(r => r.IsChecked == true);
            if (selectedRadioButton != null)
            {
                artInfo.ArtStyle = selectedRadioButton.Content.ToString();
            }
        



        }
    }

}
