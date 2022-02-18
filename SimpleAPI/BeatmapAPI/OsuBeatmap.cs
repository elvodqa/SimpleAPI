using System;
using System.Text.Json;

namespace SimpleAPI.BeatmapAPI
{
    public class OsuBeatmap
    {
        public string SongName { get; set; }
        public string SongArtist { get; set; }
        public string Mapper { get; set; }
        public string SubmitDate { get; set; }
        public string Link { get; set; }

        public override string ToString() => JsonSerializer.Serialize<OsuBeatmap>(this);
    }
}