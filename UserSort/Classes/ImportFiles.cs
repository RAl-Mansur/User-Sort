using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSort.Classes
{
    public static class ImportFiles
    {

        public static List<User> LoadJSON(string jsonFile)
        {
            using (StreamReader sr = new StreamReader(jsonFile))
            {
                string json = sr.ReadToEnd();
                //List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                var model = JsonConvert.DeserializeObject<List<User>>(json);
                return model;
            }
        }

    }
}
