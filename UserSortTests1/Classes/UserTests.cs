using Xunit;
using UserSort.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSort.Classes.Tests
{
    public class UserTests
    {
        [Fact()]
        public void UserTest()
        {
            int user_id = 1;
            string first_name = "John";
            string last_name = "Doe";
            string username = "John1";
            string user_type = "Employee";
            string last_login_time = "2015-01-12T12:01:34+00:00";

            var user = new User(user_id, first_name, last_name, username, user_type, last_login_time);

            Assert.Equal(user_id, user.user_id);
            Assert.Equal(first_name, user.first_name);
            Assert.Equal(last_name, user.last_name);
            Assert.Equal(username, user.username);
            Assert.Equal(user_type, user.user_type);
            Assert.Equal(last_login_time, user.last_login_time);
        }
    }
}