using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class PostsDatesSaved
    {
        public List<string> NamesSaved { get; set; }
        public string UserId { get; set; }
        public List<DateTime> DatesSaved { get; set; }
        public decimal LastDay { get; set; }
        public decimal LastMonth { get; set; }
        public decimal LastYear { get; set; }
        private PostsDatesSaved()
        {
            NamesSaved = new List<string>();
            DatesSaved = new List<DateTime>();
        }
        public void SaveToFile()
        {
            using (Stream stream = new FileStream(createPath(UserId), FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
        public static PostsDatesSaved LoadToFile(string i_UserId)
        {
            PostsDatesSaved obj = new PostsDatesSaved();
            string path = createPath(i_UserId);
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Length > 0)
                {
                    using (Stream stream = new FileStream(path, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(PostsDatesSaved));
                        obj = serializer.Deserialize(stream) as PostsDatesSaved;
                    }
                }
            }
            return obj;
        }
        private static string createPath(string i_UserId)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = $"{i_UserId}.xml";
            return Path.Combine(projectDirectory, fileName);
        }
    }
}
