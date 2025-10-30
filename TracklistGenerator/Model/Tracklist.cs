﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracklistGenerator.Model
{
    public class Tracklist
    {
        public int id { get; private set; }
        public string name { get; private set; }

        public string track_id_json_string { get; private set; }
        public string track_artist_json_string { get; private set; }
        public string track_title_json_string { get; private set; }
        public string track_start_time_json_string { get; private set; }
        public string track_end_time_json_string { get; private set; }

        public List<Track> tracks { get; private set; }

        public Tracklist()
        {
            id = 1;
            name = string.Empty;

            track_id_json_string = string.Empty;
            track_artist_json_string = string.Empty;
            track_title_json_string = string.Empty;
            track_start_time_json_string = string.Empty;
            track_end_time_json_string = string.Empty;

            tracks = new List<Track>();
        }

        public Tracklist(int id, string name, string track_id_json_string, string track_artist_json_string, string track_title_json_string, string track_start_time_json_string, string track_end_time_json_string, List<Track> tracks)
        {
            this.id = id;
            this.name = name;

            this.track_id_json_string = track_id_json_string;
            this.track_artist_json_string = track_artist_json_string;
            this.track_title_json_string = track_title_json_string;
            this.track_start_time_json_string = track_start_time_json_string;
            this.track_end_time_json_string = track_end_time_json_string;

            this.tracks = tracks;
        }

        public void ExportJson(string file_path)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("{");
            sb.AppendLine($"\t\"id\": {id},");
            sb.AppendLine($"\t\"name\": \"{name} Tracklist\",");
            sb.AppendLine("\t\"tracks\": [");
            
            foreach (Track track in tracks)
            {
                sb.Append("\t\t{");
                sb.Append($"\"{track_id_json_string}\": {track.id}, \"{track_artist_json_string}\": \"{track.artist}\", \"{track_title_json_string}\": \"{track.title}\", \"{track_start_time_json_string}\": {track.start_time}, \"{track_end_time_json_string}\": {track.end_time}");
                sb.AppendLine("},");
            }

            sb.AppendLine("]}");

            File.WriteAllText(file_path, sb.ToString());
        }
    }
}
