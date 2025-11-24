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
    /// <summary>
    /// Provides static methods for reading, deserializing, and managing Ableton project and SQL configuration files.
    /// </summary>
    /// <remarks>This class offers utility functions for handling configuration files related to Ableton
    /// projects and database connections. All members are static and thread-safe for independent calls. Callers are
    /// responsible for ensuring that file paths and version strings conform to expected formats to avoid runtime
    /// errors.</remarks>
    public static class ConfigurationManager
    {
        /// <summary>
        /// Deserializes an Ableton project configuration from the specified XML file.
        /// </summary>
        /// <param name="config_path">The path to the XML configuration file to deserialize. Cannot be null or empty.</param>
        /// <returns>An instance of AbletonProjectConfig containing the configuration values read from the XML file.</returns>
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

        /// <summary>
        /// Retrieves the database connection string from the specified SQL configuration file.
        /// </summary>
        /// <remarks>The configuration file is expected to contain a 'CONNECTION_STRING' XML element. If
        /// the element is missing or the file is not in the expected format, an exception may be thrown at
        /// runtime.</remarks>
        /// <param name="sql_config_path">The full path to the SQL configuration file containing the connection string. The file must exist and be
        /// accessible.</param>
        /// <returns>A string containing the database connection string as specified in the configuration file.</returns>
        /// <exception cref="FileNotFoundException">Thrown if the file specified by sql_config_path does not exist.</exception>
        public static string GetConnectionString(string sql_config_path)
        {
            if (!File.Exists(sql_config_path))
            {
                throw new FileNotFoundException($"SQL configuration file not found at path: {sql_config_path}");
            }

            XmlDocument config = new XmlDocument();
            config.Load(sql_config_path);
            string connection_string = config.GetElementsByTagName("CONNECTION_STRING").Item(0).InnerText.ToString();

            return connection_string;
        }

        /// <summary>
        /// Constructs the file path for a configuration XML file based on the specified major and minor version
        /// identifiers.
        /// </summary>
        /// <remarks>The generated file path is based on the executing assembly's location and follows the
        /// pattern: 'Configs/{major_version}-{minor_version}.xml', where the minor version is truncated at the first
        /// underscore and periods are replaced with hyphens. Callers should ensure the input format matches
        /// expectations to avoid incorrect file paths.</remarks>
        /// <param name="major_version">The major version component used to build the configuration file name. Cannot be null or empty.</param>
        /// <param name="minor_version">The minor version component, expected to contain an underscore ('_') and a period ('.'), used to build the
        /// configuration file name. Cannot be null or empty.</param>
        /// <returns>A string containing the full file path to the configuration XML file corresponding to the specified version.
        /// The file may not exist.</returns>
        public static string DetermineFilePath(string major_version, string minor_version)
        {
            string base_location = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}Configs{Path.DirectorySeparatorChar}";
            string file_name = $"{major_version}-{(minor_version.Substring(0, minor_version.IndexOf('_'))).Replace('.', '-')}";
            return $"{base_location}{file_name}.xml";
        }
    }
}
