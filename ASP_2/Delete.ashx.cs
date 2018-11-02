using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ASP_2
{
    /// <summary>
    /// Summary description for Delete
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            foreach (string VARIABLE in Users.list)
            {
                string log = VARIABLE;
                var log_del = Singleton.GetSingleton.UsersList.Find(User => User.Login == log);
                if (log_del != null)
                {
                    Singleton.GetSingleton.UsersList.Remove(log_del);
                }
            }
            context.Server.Transfer("Users.aspx");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}