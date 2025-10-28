using System;

namespace TracklistGenerator.Model
{
    public class Track
    {
        public int id { get; private set; }
        public string artist { get; private set; }
        public string title { get; private set; }
        public decimal start_time { get; private set; }
        public decimal end_time { get; private set; }

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
    }
}
