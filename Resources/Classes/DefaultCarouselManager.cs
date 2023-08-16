using System;
using System.Globalization;
using System.IO;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace myWallpaperCarousel.Resources.Classes
{
    public class DefaultCarouselManager : IDisposable
    {
        private HandleCarousel carousel;

        public DefaultCarouselManager(string defaultConfigFilePath)
        {
            if (File.Exists(defaultConfigFilePath))
            {
                WallpaperSettings settings = SaveSettingsHandler.RetrieveSettings();
                if(settings != null)
                {
                    //MessageBox.Show($"FolderPath: {settings.FolderPath}\nInterval: {settings.Interval}\nIsRandomize: {settings.IsRandomize}");
                    carousel = new HandleCarousel(settings);
                }
            }
        }

        public void Dispose()
        {
            carousel?.Dispose();
        }
    }
}