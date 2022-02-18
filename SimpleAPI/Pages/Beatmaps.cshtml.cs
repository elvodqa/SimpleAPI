using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SimpleAPI.BeatmapAPI;
using SimpleAPI.BeatmapAPI.Services;

namespace SimpleAPI.Pages
{
    public class Beatmaps : PageModel
    {
        public readonly BeatmapService BeatmapService;
        public IEnumerable<OsuBeatmap> OsuBeatmaps { get; private set; }

        public Beatmaps(ILogger<IndexModel> logger, BeatmapService beatmapService)
        {
            BeatmapService = beatmapService;
        }
        
        public void OnGet()
        {
            
            OsuBeatmaps = BeatmapService.GetBeatmaps();
        }
    }
}