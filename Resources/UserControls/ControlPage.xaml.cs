using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
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
using Ookii.Dialogs.Wpf;
using myWallpaperCarousel.Resources.Classes;

namespace myWallpaperCarousel.Resources.UserControls
{
    /// <summary>
    /// Interaction logic for ControlPage.xaml
    /// </summary>
    public partial class ControlPage : UserControl
    {
        public string FolderPath = null!;  //Folder Path containing string 
        public string[] PngFiles = null!; 
        public ObservableCollection<BitmapImage> SelectedImagePaths { get; } = new ObservableCollection<BitmapImage>();

        public ControlPage()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog();
            if (dialog.ShowDialog() == true)
            {
                string selectedFolderPath = dialog.SelectedPath;
                folderPathTextBox.Text = selectedFolderPath;
                FolderPath = selectedFolderPath;
            }
        }

        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(FolderPath) && Directory.Exists(FolderPath))
            {
                PngFiles = Directory.GetFiles(FolderPath, "*.jpg");

                SelectedImagePaths.Clear();
                foreach (string pngFile in PngFiles)
                {
                    // Load the image and generate a thumbnail
                    using (var stream = new FileStream(pngFile, FileMode.Open, FileAccess.Read))
                    {
                        var bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.DecodePixelWidth = 100; // Set the desired thumbnail width
                        bitmap.StreamSource = stream;
                        bitmap.CacheOption = BitmapCacheOption.OnLoad;
                        bitmap.EndInit();
                        bitmap.Freeze(); // Freeze the bitmap to ensure it can be accessed from other threads
                        SelectedImagePaths.Add(bitmap);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a valid folder Path.");
            }
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(FolderPath) || !Directory.Exists(FolderPath))
            {
                MessageBox.Show("Please provide a valid Folder/Directory Path");
            }
            if (TimeSpan.TryParseExact(intervalTimeInMinutes.Text, "mm", CultureInfo.InvariantCulture, out TimeSpan interval))
            {
                bool isRandomize = randomizeCheckBox.IsChecked ?? false;

                WallpaperSettings currentSettings = new WallpaperSettings(FolderPath, interval, isRandomize);
                //HandleCarousel.ApplyNewSettings(currentSettings);
            }
            else
            {
                MessageBox.Show("Invalid interval time format. Please use the format 'mm' for minutes.");
                return;
            }
        }
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            //HandleCarousel.StopCarousel(); Handle the logic to stop the carousel if status is running
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
