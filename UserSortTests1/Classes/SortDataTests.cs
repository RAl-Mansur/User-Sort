using Xunit;
using UserSort.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSort.Classes.Tests
{
    public class SortDataTests
    {

        [Fact()]
        public void ConvertLoginTimeTest()
        {
            List<User> users = new List<User>();
            users.Add(new User(1, "John", "Doe", "John1", "Employee", "12-01-2015 12:01:34"));

            SortData.ConvertLoginTime(users);
                             
            Assert.Equal("2015-01-12T12:01:34+00:00", users[0].last_login_time);
        }
    }
}