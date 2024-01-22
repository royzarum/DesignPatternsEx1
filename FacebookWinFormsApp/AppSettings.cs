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
        public bool RememberMe { get; set; }
        public string LastAccessToken { get; set; }
        private AppSettings()
        {
            RememberMe = false;
            LastAccessToken = null;
        }

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
            string path = createPath();
            if(!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                FileInfo fileInfo = new FileInfo(path);
                if(fileInfo.Length > 0)
                {
                    using (Stream stream = new FileStream(path, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        obj = serializer.Deserialize(stream) as AppSettings;
                    }
                }
            }
            return obj;
        }
        private string createPath()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "App Settings.xml";
            return Path.Combine(projectDirectory, fileName);
        }
    }
}
