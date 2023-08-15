using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Hardcodet.Wpf.TaskbarNotification;

namespace myWallpaperCarousel
{
    public partial class App : Application
    {
        private TaskbarIcon tb = null!;

        private void InitApplication()
        {
            tb = (TaskbarIcon)FindResource("SystemTrayIcon");
        }
    }
}
