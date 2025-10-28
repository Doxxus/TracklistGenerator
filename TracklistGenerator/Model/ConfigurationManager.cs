using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;

namespace TracklistGenerator
{
    public static class ConfigurationManager
    {
        public static AbletonProjectConfig DeserializeConfig(string config_path)
        {
            XmlDocument config = new XmlDocument();
            config.Load(config_path);

            string tempo_xpath = config.GetElementsByTagName("TempoXPath").Item(0).InnerText.ToString();
            string audio_track_name = config.GetElementsByTagName("AudioTrackName").Item(0).InnerText.ToString();
            string audio_clip_xpath = config.GetElementsByTagName("AudioClipXPath").Item(0).InnerText.ToString();
            string clip_name = config.GetElementsByTagName("ClipName").Item(0).InnerText.ToString();
            string clip_current_start = config.GetElementsByTagName("ClipCurrentStart").Item(0).InnerText.ToString();
            string clip_current_end = config.GetElementsByTagName("ClipCurrentEnd").Item(0).InnerText.ToString();

            return new AbletonProjectConfig(tempo_xpath, audio_track_name, audio_clip_xpath, clip_name, clip_current_start, clip_current_end);
        }

        public static string DetermineFilePath(string major_version, string minor_version)
        {
            string base_location = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}Configs{Path.DirectorySeparatorChar}";
            string file_name = $"{major_version}-{(minor_version.Substring(0, minor_version.IndexOf('_'))).Replace('.', '-')}";
            return $"{base_location}{file_name}.xml";
        }
    }
}
