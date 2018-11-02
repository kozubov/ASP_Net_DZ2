using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink_ToUsers.NavigateUrl = "Users.aspx";
        }

        protected void Button_Add_OnClick(object sender, EventArgs e)
        {
            Singleton.GetSingleton.SetUser(TextBox_Name.Text, TextBox_Surname.Text, TextBox_City.Text, TextBox_Mail.Text,
                TextBox_Password.Text, TextBox_login.Text, DropDownList_Roles.SelectedItem.Text);
            TextBox_Name.Text = null;
            TextBox_Surname.Text = null;
            TextBox_City.Text = null;
            TextBox_Mail.Text = null;
            TextBox_Password.Text = null;
            TextBox_login.Text = null;
            DropDownList_Roles.SelectedIndex = 0;
        }
    }
}