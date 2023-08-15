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

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //Initialize NotifyIcon
            tb = (TaskbarIcon)FindResource("myNotifyIcon");
        }

        
    }
}
