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
                User user = new User();

                user.user_id = Convert.ToInt32(node.ChildNodes[0].InnerText);
                user.first_name = node.ChildNodes[1].InnerText;
                user.last_name = node.ChildNodes[2].InnerText;
                user.username = node.ChildNodes[3].InnerText;
                user.user_type = node.ChildNodes[4].InnerText;
                user.last_login_time = node.ChildNodes[5].InnerText;

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
                //bool isFirstLine = true;

                parser.ReadLine(); // Read header

                while (!parser.EndOfData)
                {
                    //if (isFirstLine)
                    //{
                    //    isFirstLine = false;
                    //    continue;
                    //}

                    User user = new User();
                    string[] fields = parser.ReadFields();

                    user.user_id = Convert.ToInt32(fields[0]);
                    user.first_name = fields[1];
                    user.last_name = fields[2];
                    user.username = fields[3];
                    user.user_type = fields[4];
                    user.last_login_time = fields[5];

                    users.Add(user);
                }
            }
            return users;
        }

    }
}
