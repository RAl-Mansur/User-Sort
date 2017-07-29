using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Reflection;
using System.ComponentModel;


namespace UserSort.Classes
{
    public static class ExportData
    {
        // Convert generic list to XML
        public static void ExportXML(List<User> users, string path)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using (var stream = File.OpenWrite(path + ".xml"))
            {
                serializer.Serialize(stream, users);
            }
        }

        // Convert generic list to JSON data
        public static void ExportJSON(List<User> users, string path)
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(path + @".json", json);
        }

        // Convert generic list to CSV format
        public static void ExportCSV<T>(IEnumerable<T> items, string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            using (var writer = new StreamWriter(path + @".csv"))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.GetCustomAttribute<DisplayNameAttribute>().DisplayName)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }

    }
}
