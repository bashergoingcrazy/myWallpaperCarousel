﻿using myWallpaperCarousel.Resources.Classes;
using myWallpaperCarousel.Resources.UserControls;
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

namespace myWallpaperCarousel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ControlPage controlPage;
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            //DataContext = ViewModel.Instance;

        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Visibility = Visibility.Collapsed;
            
        }

        public void HanldeStausBar(int state)
        {
            switch (state)
            {
                case 1:
                    StatusFlag.Content = "Running";
                    StatusFlag.Foreground = Brushes.Green;
                    break;
                case 2:
                    StatusFlag.Content = "Stopped";
                    StatusFlag.Foreground = Brushes.Red;
                    break;
            }
        }
    }
}
