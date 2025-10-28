using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SharpCompress.Compressors.Deflate;
using SharpCompress.Compressors;

namespace TracklistGenerator.Model
{
    public static class ProjectFileParser
    {
        public static async Task<List<Track>> GetTracklistFromProject(string project_file_path)
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



            });

            return tracklist;
        }
    }
}
