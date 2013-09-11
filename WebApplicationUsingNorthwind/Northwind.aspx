<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Northwind.aspx.cs" Inherits="WebApplicationUsingNorthwind.Northwind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:GridView ID="GridViewCustomers" runat="server" AutoGenerateColumns="false" DataKeyNames="EmployeeID">
             <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="City" HeaderText="City" />
                
                <asp:HyperLinkField Text="Details" DataNavigateUrlFields="EmployeeID"
                    DataNavigateUrlFormatString="DetailsEmployee.aspx?id={0}" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
