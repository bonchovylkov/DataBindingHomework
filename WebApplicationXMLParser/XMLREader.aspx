<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLREader.aspx.cs" Inherits="WebApplicationXMLParser.XMLREader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <%--   <asp:FileUpload ID="FileUploder" runat="server" />
        <asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />--%>
       
        <asp:XmlDataSource DataFile="~/bookmarks.xml" id="XmlDocument" runat="server">

        </asp:XmlDataSource>
    </div>
        <asp:TreeView ID="TreeView1" OnTreeNodeDataBound="TreeView1_TreeNodeDataBound" runat="server" DataSourceID="XmlDocument">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="bookmarks" ImageUrl="~/images.jpg" ToolTipField="#InnerText" ValueField="#Name" />
                <asp:TreeNodeBinding DataMember="bookmark" ValueField="#Name" />
                <asp:TreeNodeBinding DataMember="username" ToolTipField="#InnerText" ValueField="#Name" />
                <asp:TreeNodeBinding DataMember="password" ToolTipField="#InnerText" ValueField="#Name" />
                <asp:TreeNodeBinding DataMember="title" ToolTipField="#InnerText" ValueField="#Name" />
                <asp:TreeNodeBinding DataMember="url" ToolTipField="#InnerText" ValueField="#Name" />
                <asp:TreeNodeBinding DataMember="tags" ToolTipField="#InnerText" ValueField="#Name" />
            </DataBindings>
        </asp:TreeView>
    </form>
</body>
</html>
