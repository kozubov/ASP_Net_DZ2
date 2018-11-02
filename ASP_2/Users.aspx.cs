using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_2
{
    public partial class Users : System.Web.UI.Page
    {
        public static List<string> list = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show_Users();
            }
            Add_LinkButtons();
            button_delete.PostBackUrl = "Delete.ashx";
            button_tousers.PostBackUrl = "Default.aspx";
        }
        private void Add_LinkButtons()
        {
            foreach (User VARIABLE in Singleton.GetSingleton.UsersList)
            {
                LinkButton button = new LinkButton();
                button.Text = "Edit";
                button.PostBackUrl = $"Edit_User.aspx?value={VARIABLE.Id}";
                Panel1.Controls.Add(button);
            }
        }

        private void Show_Users()
        {
            foreach (User VARIABLE in Singleton.GetSingleton.UsersList)
            {
                CheckBoxList1.Items.Add(VARIABLE.Login.ToString());
            }
        }

        protected void CheckBoxList1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    button_delete.Enabled = true;
                    break;
                }
                else
                {
                    button_delete.Enabled = false;
                }
            }
            list.Clear();
            for (int j = 0; j < CheckBoxList1.Items.Count; j++)
            {
                if (CheckBoxList1.Items[j].Selected)
                {
                    string str = CheckBoxList1.Items[j].ToString();
                    //foreach (string s in str)
                    //{
                    //   if (!s.Equals("User"))
                    //    {
                            list.Add(str);
                    //    }
                    //}
                }
            }
        }
    }
}