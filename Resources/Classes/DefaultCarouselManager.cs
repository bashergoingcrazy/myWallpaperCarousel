using System;
using System.IO;
using Newtonsoft.Json;

namespace myWallpaperCarousel.Resources.Classes
{
    public class DefaultCarouselManager : IDisposable
    {
        private HandleCarousel carousel;

        public DefaultCarouselManager(string defaultConfigFilePath)
        {
            if (File.Exists(defaultConfigFilePath))
            {
                string json = File.ReadAllText(defaultConfigFilePath);
                WallpaperSettings settings = JsonConvert.DeserializeObject<WallpaperSettings>(json);
                carousel = new HandleCarousel(settings);
            }
        }

        public void Dispose()
        {
            carousel?.Dispose();
        }
    }
}