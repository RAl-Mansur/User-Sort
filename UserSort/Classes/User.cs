using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSort.Classes
{
    /// <summary>
    /// User class. Object will hold data imported from files 
    /// </summary>
    public class User
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string user_type { get; set; }
        public string last_login_time { get; set; }

        public User() { }

        public User(int userID, string fName, string lName, string username, string type, string lastLogin)
        {
            this.user_id = userID;
            this.first_name = fName;
            this.last_name = lName;
            this.username = username;
            this.user_type = type;
            this.last_login_time = lastLogin;
        }


    }
}
