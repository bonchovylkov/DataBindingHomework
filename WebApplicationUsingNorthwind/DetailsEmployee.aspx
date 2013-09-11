<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsEmployee.aspx.cs" Inherits="WebApplicationUsingNorthwind.DetailsEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink runat="server" NavigateUrl="Northwind.aspx" Text="Back" ></asp:HyperLink>
    <asp:DetailsView ID="DetailsViewEmployee" runat="server" AutoGenerateRows="true">
             
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
