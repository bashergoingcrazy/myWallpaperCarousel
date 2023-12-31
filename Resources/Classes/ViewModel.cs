﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace myWallpaperCarousel.Resources.Classes
{
    public class ViewModel
    {

        private DefaultCarouselManager defaultCarouselManager;

        public ICommand OpenSettingsCommand { get; } = new RelayCommand(OpenSettings);
        public ICommand ExitCommand { get; } = new RelayCommand(Exit);

        public ViewModel()
        {
            string defaultConfigFilePath = "C:\\Users\\vansh\\AppData\\Local\\myWallpaperCarousel\\defaults.json";
            defaultCarouselManager = new DefaultCarouselManager(defaultConfigFilePath);
        }

        private static void OpenSettings(object parameter)
        {
            //Dispose of the default Carousel Manager
            Instance.defaultCarouselManager.Dispose();

            // Implement your logic to open settings
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

            if (mainWindow != null)
            {
                mainWindow.Visibility = Visibility.Visible; // Set the visibility to Visible
                mainWindow.Activate();
            }
            else
            {
                mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }

        private static void Exit(object parameter)
        {
            // Implement your logic to exit the application
            Application.Current.Shutdown();
        }

        // Singleton instance of ViewModel
        private static ViewModel _instance;
        public static ViewModel Instance => _instance ??= new ViewModel();
    }
}
