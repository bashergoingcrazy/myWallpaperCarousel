using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace myWallpaperCarousel.Resources.Classes
{
    public class WallpaperSettings
    {
        public string FolderPath { get; }
        public TimeSpan Interval { get; }
        public bool IsRandomize { get; }

        public WallpaperSettings(string folderPath, TimeSpan interval, bool isRandomize)
        {
            FolderPath = folderPath;
            Interval = interval;
            IsRandomize = isRandomize;
        }

        public WallpaperSettings() : this("", TimeSpan.Zero, false)
        {
            FolderPath = "C:\\Users\\vansh\\OneDrive\\Pictures\\Saved Pictures";
            Interval = TimeSpan.FromMinutes(01);
            IsRandomize = false;
        }
    }
}
