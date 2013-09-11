<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="EmployeesView.aspx.cs" 
    Inherits="WebApplicationEmployeesUseingFormView.EmployeesView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:FormView ID="EmployeesFromViewId" runat="server" AllowPaging="true" OnPageIndexChanging="EmployeesFromViewId_PageIndexChanging">
           <ItemTemplate>
                   <h3><%#: Eval("FirstName") + " " + Eval("LastName") %></h3>
                <table border="0">
                    <tr>
                        <td>City:</td>
                        <td><%#: Eval("City")%></td>
                    </tr>
                    <tr>
                        <td>Country:</td>
                        <td><%#: Eval("Country")%></td>
                    </tr>
                </table>
                <hr />
           </ItemTemplate>
             <EditItemTemplate>
                   <h3><%#: Eval("FirstName") + " " + Eval("LastName") %></h3>
                <table border="0">
                    <tr>
                        <td>City:</td>
                        <td><asp:TextBox ID="TextBoxCity" runat="server" 
                            Text='<%# Eval("City") %>' /></td>
                    </tr>
                    <tr>
                        <td>Country:</td>
                        <td><asp:TextBox ID="TextBoxCountry" runat="server" 
                            Text='<%# Eval("Country") %>' /></td>
                    </tr>
                </table>
                <hr />
           </EditItemTemplate>
       </asp:FormView>

          <asp:MultiView ID="MultiViewButtons" runat="server" ActiveViewIndex="0">
            <asp:View ID="ViewNormalMode" runat="server">
                <asp:LinkButton ID="LinkButtonEdit" runat="server" 
                    onclick="LinkButtonEdit_Click" Text="Edit" />
            </asp:View>
            <asp:View ID="ViewEditMode" runat="server">
                <asp:LinkButton ID="LinkButtonSave" runat="server" 
                    onclick="LinkButtonSave_Click" Text="Save" />
                <asp:LinkButton ID="LinkButtonCancel" runat="server" 
                    onclick="LinkButtonCancel_Click" Text="Cancel" />
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
