using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic;
using UserSort.Classes;
using Microsoft.VisualBasic.FileIO;

namespace UserSort.Classes
{
    /// <summary>
    ///     Methods used to import CSV, JSON and XML files
    /// </summary>
    public static class ImportFiles
    {

        // Read JSON file and return a list of User objects
        public static List<User> LoadJSON(string jsonFile)
        {
            using (StreamReader sr = new StreamReader(jsonFile))
            {
                string json = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
        }

        // Read XML File and return a list of Users
        public static List<User> LoadXML(string xmlFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);

            List<User> users = new List<User>();

            foreach (XmlNode node in doc.DocumentElement)
            {
                User user = new User(Convert.ToInt32(node.ChildNodes[0].InnerText), node.ChildNodes[1].InnerText, 
                    node.ChildNodes[2].InnerText, node.ChildNodes[3].InnerText, node.ChildNodes[4].InnerText, 
                    node.ChildNodes[5].InnerText);

                users.Add(user);
            }
            return users;
        }


        // Read CSV File and return a list of Users
        public static List<User> LoadCSV(string csvFile)
        {
            List<User> users = new List<User>();

            using (TextFieldParser parser = new TextFieldParser(csvFile))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                parser.ReadLine(); // Read header

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    User user = new User(Convert.ToInt32(fields[0]), fields[1], fields[2], fields[3], fields[4], fields[5]);
                    users.Add(user);
                }
            }
            return users;
        }


        
    }
}
