using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSort.Classes
{
    public static class SortData
    {

        public static List<User> SortByUserID(List<User> userList)
        {
            List<User> users = userList.OrderBy(o => o.user_id).ToList();
            return users;
        }

    }
}
