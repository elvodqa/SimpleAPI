using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;

namespace SimpleAPI.BeatmapAPI.Services
{
    public class BeatmapService
    {
        public IWebHostEnvironment _whe { get; }
        public BeatmapService(IWebHostEnvironment webHostEnvironment)
        {
            _whe = webHostEnvironment;
        }

        private string JsonFileName
        {
            get
            {
                return Path.Combine(_whe.WebRootPath, "BeatmapData", "beatmaps.json");
            }
        }

        public IEnumerable<OsuBeatmap> GetBeatmaps()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<OsuBeatmap[]>(jsonFileReader.ReadToEnd(), 
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );
            }
        }
        
    }
}