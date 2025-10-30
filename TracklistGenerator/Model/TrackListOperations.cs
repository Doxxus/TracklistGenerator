using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TracklistGenerator.Model
{
    public static class TrackListOperations
    {
        public static void Sort(ref List<Track> tracklist)
        {
            tracklist.Sort((a, b) => a.start_time.CompareTo(b.start_time));

            for (int i = 0; i < tracklist.Count; i++) 
            {
                tracklist[i].ChangeId(i + 1);
            }
        }

        public static void CombineAllDuplicates(ref List<Track> tracklist)
        {
            List<Track> rectified_tracklist = new List<Track>();
            Sort(ref tracklist);

            List<int> ids_to_skip = new List<int>();

            for (int i = 0; i < tracklist.Count - 1; i++)
            {
                Track track_to_search_for = tracklist[i];
                List<Track> duplicates = new List<Track>();

                if (ids_to_skip.Contains(track_to_search_for.id)) continue;

                for (int j = i + 1; j < tracklist.Count; j++)
                {
                    if (track_to_search_for.GetFullName() != tracklist[j].GetFullName()) continue;
                    duplicates.Add(tracklist[j]);
                    ids_to_skip.Add(tracklist[j].id);
                }

                if (duplicates.Count > 0)
                {
                    duplicates.Add(track_to_search_for);
                    decimal min_start_time = decimal.MaxValue;
                    decimal max_end_time = decimal.MinValue;

                    foreach (Track track in duplicates)
                    {
                        if (track.start_time < min_start_time) min_start_time = track.start_time;
                        if (track.end_time > max_end_time) max_end_time = track.end_time;
                    }

                    rectified_tracklist.Add(new Track(track_to_search_for.id, track_to_search_for.artist, track_to_search_for.title, min_start_time, max_end_time));
                }
                else
                {
                    rectified_tracklist.Add(track_to_search_for);
                }
            }

            if (!rectified_tracklist.ContainsTrack(tracklist[tracklist.Count - 1])) rectified_tracklist.Add(tracklist[tracklist.Count - 1]);

            Sort(ref rectified_tracklist);
            tracklist = rectified_tracklist;
        }

        public static bool ContainsTrack(this IEnumerable<Track> tracks, Track target)
        {
            return tracks.Any(t => t.GetFullName() == target.GetFullName());
        }
    }
}
