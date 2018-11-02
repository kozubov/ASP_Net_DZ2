using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_2
{
    public partial class Edit_User : System.Web.UI.Page
    {
        private static int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink_ToUsers.NavigateUrl = "Users.aspx";
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["value"]);
                foreach (User VARIABLE in Singleton.GetSingleton.UsersList)
                {
                    if (id == VARIABLE.Id)
                    {
                        TextBox_Name.Text = VARIABLE.FirstName;
                        TextBox_Surname.Text = VARIABLE.SurName;
                        TextBox_City.Text = VARIABLE.City;
                        TextBox_Mail.Text = VARIABLE.EMail;
                        TextBox_Password.Text = VARIABLE.Password;
                        TextBox_login.Text = VARIABLE.Login;
                        foreach (ListItem R in DropDownList_Roles.Items)
                        {
                            R.Selected = false || VARIABLE.role.Role_type.Equals(R.Text);
                        }
                    }
                }
            }
        }

        protected void Button_Save_OnClick(object sender, EventArgs e)
        {
            foreach (User user in Singleton.GetSingleton.UsersList)
            {
                if (id == user.Id)
                {
                    user.EditUser(TextBox_Name.Text, TextBox_Surname.Text, TextBox_City.Text, TextBox_Mail.Text,
                        TextBox_Password.Text, TextBox_login.Text, DropDownList_Roles.SelectedItem.Text);
                }
            }
            Server.Transfer("Users.aspx");
        }
    }
}