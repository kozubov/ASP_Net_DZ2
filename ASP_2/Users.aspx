<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="ASP_2.Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="style.css" rel="stylesheet" />
<link href="https://fonts.googleapis.com/css?family=Cuprum:400,400i,700,700i&amp;subset=cyrillic" rel="stylesheet" />
<title>Users List</title>
</head>
<body>
    <div class="title_form"><span>Users</span> List</div>
    <form class="form_list" id="form1" runat="server">
        <div class="users_list">
            <div class="checkbox">
                <asp:CheckBoxList ID="CheckBoxList1" CssClass="mycheckbox" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_OnSelectedIndexChanged"></asp:CheckBoxList>
            </div>
            <asp:Panel ID="Panel1" runat="server" CssClass="button_edit"></asp:Panel>
        </div>
        <div class="buttons"></div>
        <asp:LinkButton ID="button_delete" runat="server" Enabled="False" CssClass="button_delete">Delete</asp:LinkButton>
        <asp:LinkButton ID="button_tousers" runat="server" CssClass="button_link">Back to ADD Form</asp:LinkButton>
    </form>
</body>
</html>
