<%@ Page Language="C#"
     AutoEventWireup="true" 
    CodeBehind="Repeater.aspx.cs"
     Inherits="WebApplicationRepeater.Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <asp:Repeater ID="RepeaterEmployees" runat="server">
            <ItemTemplate>
                <li>
                    <a href="#"><%#: Eval("FirstName") %> : <%#: Eval("City") %></a>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
