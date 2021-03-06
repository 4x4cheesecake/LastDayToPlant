﻿using StardewModdingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDayToPlant
{
    public class Crop
    {
        public string Name { get; set; }
        public int DaysToMature { get; set; }
        public string Message { get; private set; }
        public string MessageSpeedGro { get; private set; }
        public string MessageDelxueSpeedGro { get; private set; }
        public string MessageHyperSpeedGro { get; private set; }


        public Crop(string name, int daysToMature)
        {
            Name = name;
            DaysToMature = daysToMature;
        }

        public static Crop GetLocalizedCrop(string season, string name, int daysToMature, IModHelper helper)
        {
            var tagName = name.Replace(" ", "").Trim().ToLower();

            var crop = new Crop(helper.Translation.Get($"crop.{season}.{tagName}", new { cropName = name }), daysToMature)
            {
                Message = helper.Translation.Get("notification.crop.no-fertilizer", new { cropName = name }),
                MessageSpeedGro = helper.Translation.Get("notification.crop.speed-gro", new { cropName = name }),
                MessageDelxueSpeedGro = helper.Translation.Get("notification.crop.deluxe-speed-gro", new { cropName = name }),
                MessageHyperSpeedGro = helper.Translation.Get("notification.crop.hyper-speed-gro", new { cropName = name })
            };

            return crop;
        }
    }
}
