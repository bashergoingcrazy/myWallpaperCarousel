using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace myWallpaperCarousel.Resources.Classes
{
    class SaveSettingsHandler
    {
        private static readonly string AppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "myWallpaperCarousel");
        private static readonly string SettingsFilePath = Path.Combine(AppDataFolder, "defaults.json");

        public static void SaveSettings(WallpaperSettings settings)
        {
            try
            {
                if (!Directory.Exists(AppDataFolder))
                {
                    Directory.CreateDirectory(AppDataFolder);
                }

                string intervalMinutes = settings.Interval.Minutes.ToString("D2");

                // Create a new object to hold the modified settings
                var modifiedSettings = new
                {
                    settings.FolderPath,
                    Interval = intervalMinutes,
                    settings.IsRandomize
                };

                string json = JsonConvert.SerializeObject(modifiedSettings, Formatting.Indented);
                File.WriteAllText(SettingsFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static WallpaperSettings RetrieveSettings()
        {
            try
            {
                //MessageBox.Show($"path:{SettingsFilePath}");
                if (File.Exists(SettingsFilePath))
                {
                    string json = File.ReadAllText(SettingsFilePath);
                    var jsonObject = JsonConvert.DeserializeObject<JObject>(json);
                        
                    if(jsonObject == null)
                    {
                        return null;
                    }
                    string folderPath = jsonObject["FolderPath"]?.ToString() ?? "";
                    string intervalString = jsonObject["Interval"]?.ToString() ?? "";
                    bool isRandomize = jsonObject["IsRandomize"]?.ToObject<bool>() ?? false;

                    // Convert intervalString to TimeSpan
                    TimeSpan interval = TimeSpan.Zero;
                    if (TimeSpan.TryParseExact(intervalString, "mm", CultureInfo.InvariantCulture, out TimeSpan parsedInterval))
                    {
                        interval = parsedInterval;
                    }
                    WallpaperSettings settings = new WallpaperSettings(folderPath,interval,isRandomize);
                    return settings;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving settings: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return new WallpaperSettings();
        }
    }
}
