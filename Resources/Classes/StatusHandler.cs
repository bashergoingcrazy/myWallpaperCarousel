using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWallpaperCarousel.Resources.Classes
{
    class StatusHandler
    {
        public string Status { get; set; }
        public string Color { get; set; }
        public event Action<string> StatusChanged;

        
    }
}
