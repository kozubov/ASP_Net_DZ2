using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_2
{
    public class Roles
    {
        private Roles() { }
        public string Role_type { get; private set; }

        public Roles(string role) => Role_type = role;
        public void Change_Role(string name) => Role_type = name;
    }
}