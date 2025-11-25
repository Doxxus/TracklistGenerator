using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using SharpCompress.Compressors.Deflate;
using SharpCompress.Compressors;
using Newtonsoft.Json;

namespace TracklistGenerator.Model
{
    /// <summary>
    /// Static class to parse various file types into lists of Track objects.
    /// </summary>
    public static class FileParser
    {
        /// <summary>
        /// Async method to parse out a List of Track objects from a given Ableton project filepath.
        /// </summary>
        /// <param name="project_file_path">The path to the Ableton project file.</param>
        /// <param name="given_tempo">The given temp to parse the tracklist as (needs to convert the beat information to time in seconds based on the time signature and bpm.</param>
        /// <returns></returns>
        public static async Task<List<Track>> GetTracklistFromProject(string project_file_path, int given_tempo = -1)
        {
            List<Track> tracklist = new List<Track>();

            await Task.Factory.StartNew(() =>
            {
                XmlDocument project_xml = new XmlDocument();

                using (FileStream input = File.OpenRead(project_file_path))
                using (GZipStream gzip_stream = new GZipStream(input, CompressionMode.Decompress))
                using (StreamReader reader = new StreamReader(gzip_stream))
                {
                    string content = reader.ReadToEnd();
                    project_xml.LoadXml(content);
                }

                string major_verson = project_xml.SelectSingleNode("Ableton").Attributes["MajorVersion"].Value.ToString();
                string minor_version = project_xml.SelectSingleNode("Ableton").Attributes["MinorVersion"].Value.ToString();

                AbletonProjectConfig config = ConfigurationManager.DeserializeConfig(ConfigurationManager.DetermineFilePath(major_verson, minor_version));

                int tempo = (given_tempo == -1 ? int.Parse(project_xml.SelectSingleNode(config.tempo_xpath).Attributes[0].Value.ToString()) : given_tempo);
                int i = 1;

                foreach (XmlNode track in project_xml.GetElementsByTagName(config.audio_track_name))
                {
                    foreach (XmlNode audio_clip in track.SelectNodes(config.audio_clip_xpath))
                    {
                        tracklist.Add(ParseTrack(audio_clip, config, tempo, i));
                        i++;
                    }
                }
            });

            return tracklist;
        }

        /// <summary>
        /// Asyn method for obtaining a List of Track objects from an already built JSON tracklist file.
        /// </summary>
        /// <param name="json_file_path"></param>
        /// <returns></returns>
        public static async Task<List<Track>> GetTracklistFromJson(string json_file_path)
        {
            List<Track> tracklist = new List<Track>();

            await Task.Factory.StartNew(() =>
            {
                using (FileStream input = File.OpenRead(json_file_path))
                using (StreamReader reader = new StreamReader(input))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!line.StartsWith("\t\t")) continue;

                        string cleaned_line = line.Trim().TrimEnd(',');
                        Track track = JsonConvert.DeserializeObject<Track>(cleaned_line);
                        tracklist.Add(track);
                    }
                }
            });

            return tracklist;
        }

        /// <summary>
        /// Parses a given XML note into a Track object based on a given AbletonProjectConfig.
        /// </summary>
        /// <param name="audio_clip"></param>
        /// <param name="config"></param>
        /// <param name="tempo"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private static Track ParseTrack(XmlNode audio_clip, AbletonProjectConfig config, int tempo, int id)
        {
            string full_track_name = audio_clip.SelectSingleNode(config.clip_name).Attributes[0].Value.ToString();
            string[] track_parts = full_track_name.Split('-').Select(part => part.Trim()).Where(part => !string.IsNullOrEmpty(part)).ToArray();

            decimal start_time = BeatsToSeconds(decimal.Parse(audio_clip.SelectSingleNode(config.clip_current_start).Attributes[0].Value.ToString()), tempo);
            decimal end_time = BeatsToSeconds(decimal.Parse(audio_clip.SelectSingleNode(config.clip_current_end).Attributes[0].Value.ToString()), tempo);

            return new Track(id, track_parts.Length > 0 ? track_parts[0] : string.Empty, track_parts.Length > 1 ? track_parts[1] : string.Empty, start_time, end_time);
        }

        /// <summary>
        /// Converts a beat value into a seconds value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="bpm"></param>
        /// <returns></returns>
        private static decimal BeatsToSeconds(decimal value, int bpm)
        {
            return Decimal.Round((value / bpm) * 60, 0);
        }
    }
}
