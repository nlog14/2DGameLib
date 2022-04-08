using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2DGameLib
{
    public class ReadConfiguration
    {
        public static int MinWorldSize { get; private set; }
        public static int MaxWorldSize { get; private set; }

        /// <summary>
        /// Uses variable path set in the system's environment variables.
        /// Reads application configuration from a configuration file.
        /// </summary>
        public static void ReadConfig()
        {
            string xml = "Config.xml";
            string path = Environment.GetEnvironmentVariable("2DGameFrameworkConfig");
            string fullPath = Path.Combine(path, xml);

            XmlDocument configDoc = new XmlDocument();
            configDoc.Load(fullPath);

            XmlNode minWorldSize = configDoc.DocumentElement.SelectSingleNode("MinWorldSize");
            if (minWorldSize != null)
            {
                string str = minWorldSize.InnerText.Trim();
                MinWorldSize = Convert.ToInt32(str);
            }

            XmlNode maxWorldSize = configDoc.DocumentElement.SelectSingleNode("MaxWorldSize");
            if (maxWorldSize != null)
            {
                string str = maxWorldSize.InnerText.Trim();
                MaxWorldSize  = Convert.ToInt32(str);
            }

            //XmlNode creatureName = configDoc.DocumentElement.SelectSingleNode("CreatureName");
            //if (creatureName != null)
            //{
            //    string str = creatureName.InnerText.Trim();
            //}
        }

    }
}
