using System;

namespace TracklistGenerator.Model
{
    public class Track
    {
        public int id { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public decimal start_time { get; set; }
        public decimal end_time { get; set; }

        public Track()
        {
            id = -1;
            artist = String.Empty;
            title = String.Empty;
            start_time = -1;
            end_time = -1;
        }

        public Track(int id, string artist, string title, decimal start_time, decimal end_time)
        {
            this.id = id;
            this.artist = artist;
            this.title = title;
            this.start_time = start_time;
            this.end_time = end_time;
        }

        public void ChangeId(int id)
        {
            this.id = id;
        }

        public string GetFullName()
        {
            return $"{artist} - {title}";
        }
    }
}