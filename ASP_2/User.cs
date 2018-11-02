using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_2
{
    public class User
    {
        public Roles role;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }

        public User(int id, string firstName, string surName, string city, string email, string password, string login,
            string roleType)
        {
            Id = id;
            FirstName = firstName;
            SurName = surName;
            City = city;
            EMail = email;
            Password = password;
            Login = login;
            role = new Roles(roleType);
        }
        public void EditUser(string firstName, string surName, string city, string email, string password, string login,
            string roleType)
        {
            FirstName = firstName;
            SurName = surName;
            City = city;
            EMail = email;
            Password = password;
            Login = login;
            role.Change_Role(roleType);
        }
    }
}