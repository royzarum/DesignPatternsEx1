using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        private bool m_RememberMe;
        private string m_LastAccessToken;

        private AppSettings()
        {
            RememberMe = false;
            LastAccessToken = null;
        }

        public bool RememberMe { get; set; }
        public string LastAccessToken { get; set; }
        public void SaveToFile()
        {
            using (Stream stream = new FileStream(createPath(), FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
        public static AppSettings LoadFromFile() 
        {
            AppSettings obj = new AppSettings();
            if(!File.Exists(createPath()))
            {
                File.Create(createPath());
            }
            else
            {
                using (Stream stream = new FileStream(createPath(), FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }
            return obj;
        }
        private static string createPath()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "App Settings.xml";
            return Path.Combine(projectDirectory, fileName);
        }
    }
}
