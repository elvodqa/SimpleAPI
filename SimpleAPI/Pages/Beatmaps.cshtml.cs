using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SimpleAPI.BeatmapAPI;
using SimpleAPI.BeatmapAPI.Services;

namespace SimpleAPI.Pages
{
    public class Beatmaps : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly BeatmapService _beatmapService;
        public IEnumerable<OsuBeatmap> OsuBeatmaps { get; private set; }

        public Beatmaps(ILogger<IndexModel> logger, BeatmapService beatmapService)
        {
            _logger = logger;
            _beatmapService = beatmapService;
        }
        
        public void OnGet()
        {
            
            OsuBeatmaps = _beatmapService.GetBeatmaps();
        }
    }
}