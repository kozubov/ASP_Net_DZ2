using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_2
{
    public class Singleton
    {
        private static Singleton single;
        public List<User> UsersList { get; set; } = new List<User>();
        private int count = 1;

        public void SetUser(string firstName, string surName, string city, string mail, string password, string login,
            string roleType)
        {
            UsersList.Add(new User(count, firstName, surName, city, mail, password, login, roleType));
            count++;
        }

        public static Singleton GetSingleton => single ?? (single = new Singleton());
    }
}