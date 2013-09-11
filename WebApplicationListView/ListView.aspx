<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListView.aspx.cs" Inherits="WebApplicationListView.ListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="EmployeeListView" runat="server">
                <LayoutTemplate>
                    <h3>Employees</h3>
                    <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                </LayoutTemplate>

                <ItemSeparatorTemplate>
                    <hr />
                </ItemSeparatorTemplate>

                <ItemTemplate>
                    <div class="product-description">
                        <h4></h4>
                        <p>
                            <%#: Eval("FirstName") %>
                        </p>
                          <p>
                            
                            <%#: Eval("LastName") %>
                           
                        </p>
                          <p>
                            <%#: Eval("City") %>
                        </p>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            <asp:DataPager ID="DataPagerCustomers" runat="server"
            PagedControlID="EmployeeListView" PageSize="3"
            QueryStringField="page">
            <Fields>
                <asp:NextPreviousPagerField ShowFirstPageButton="true"
                    ShowNextPageButton="false" ShowPreviousPageButton="false" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ShowLastPageButton="true"
                    ShowNextPageButton="false" ShowPreviousPageButton="false" />
            </Fields>
        </asp:DataPager>
        </div>
    </form>
</body>
</html>
