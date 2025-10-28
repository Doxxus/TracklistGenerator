using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracklistGenerator
{
    public class AbletonProjectConfig
    {
        public string tempo_xpath { get; private set; }
        public string audio_track_name { get; private set; }
        public string audio_clip_xpath { get; private set; }
        public string clip_name { get; private set; }
        public string clip_current_start { get; private set; }
        public string clip_current_end { get; private set; }

        public AbletonProjectConfig()
        {
            tempo_xpath = string.Empty;
            audio_track_name = string.Empty;
            audio_clip_xpath = string.Empty;            
            clip_name = string.Empty;
            clip_current_start = string.Empty;
            clip_current_end = string.Empty;
        }

        public AbletonProjectConfig(string tempo_xpath, string audio_track_name, string audio_clip_xpath, string clip_name, string clip_current_start, string clip_current_end)
        {
            this.tempo_xpath = tempo_xpath;
            this.audio_track_name = audio_track_name;
            this.audio_clip_xpath = audio_clip_xpath;
            this.clip_name = clip_name;
            this.clip_current_start = clip_current_start;
            this.clip_current_end = clip_current_end;
        }
    }
}
