using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace UserSort.Classes
{
    public static class ExportData
    {

        public static void ExportXML(List<User> users, string fileName = "users")
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using (var stream = File.OpenWrite(fileName + ".xml"))
            {
                serializer.Serialize(stream, users);
            } 
        }

        public static void ExportJSON(List<User> users, string fileName = "users")
        {
            //string json = new JavaScriptSerializer().Serialize(users);
            //File.WriteAllText(fileName + @".json", json);

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(fileName + @".json", json);
        }

    }
}
