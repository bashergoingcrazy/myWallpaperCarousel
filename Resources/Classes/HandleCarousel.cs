using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace myWallpaperCarousel.Resources.Classes
{
    public class HandleCarousel : IDisposable
    {
        private List<string> imagePaths;
        private int currentIndex;
        private TimeSpan interval;
        private Timer timer;
        private bool IsRandom;
        private string Status;

        public HandleCarousel(WallpaperSettings settings)
        {
            if (!Directory.Exists(settings.FolderPath))
            {
                throw new DirectoryNotFoundException("Folder does not exist.");
            }

            imagePaths = new List<string>(Directory.GetFiles(settings.FolderPath, "*.jpg"));

            if (imagePaths.Count == 0)
            {
                throw new InvalidOperationException("No image files found in the specified folder.");
            }

            if (settings.IsRandomize)
            {
                RandomizeImagePaths();
            }

            interval = settings.Interval;
            currentIndex = 0;
            IsRandom = settings.IsRandomize;

            timer = new Timer(TimerCallback, null, TimeSpan.Zero, interval);
        }

        private void TimerCallback(object state)
        {
            try
            {
                // Check if cancellation was requested
                Status = "Running";
                ApplyNewSettings(imagePaths[currentIndex]);
                if (IsRandom)
                {
                    RandomizeImagePaths();
                }
                else
                {
                    currentIndex = (currentIndex + 1) % imagePaths.Count;
                }
            }
            catch (OperationCanceledException)
            {
                // Timer was disposed; clean up if needed
                MessageBox.Show("Timer was disposed clean up if needed");
            }
        }

        private void RandomizeImagePaths()
        {
            Random rng = new Random();
            int n = imagePaths.Count;
            if (n > 1)
            {
                int tempIndex = currentIndex;
                while (tempIndex == currentIndex)
                {
                    tempIndex = rng.Next(0, imagePaths.Count);
                }
                currentIndex = tempIndex;
            }
        }

        private void ApplyNewSettings(string imagePath)
        {
            // For example, you can use SystemParametersInfo to change the wallpaper:
            NativeMethods.SystemParametersInfo(NativeMethods.SPI_SETDESKWALLPAPER, 0, imagePath, NativeMethods.SPIF_UPDATEINIFILE | NativeMethods.SPIF_SENDCHANGE);
        }

        public void Dispose()
        {
            Status = "Stopped";
      
            timer.Dispose();
        }
    }
    public static class NativeMethods
    {
        public const uint SPI_SETDESKWALLPAPER = 0x0014;
        public const uint SPIF_UPDATEINIFILE = 0x01;
        public const uint SPIF_SENDCHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(uint uAction, uint uParam, string lpvParam, uint fuWinIni);
    }
}
