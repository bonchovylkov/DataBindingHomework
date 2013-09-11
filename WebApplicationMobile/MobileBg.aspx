<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MobileBg.aspx.cs" Inherits="WebApplicationMobile.MobileBg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList runat="server" AutoPostBack="true" ID="ProducersDropDown" OnSelectedIndexChanged="ChangeModels" DataTextField ="Name">
            
        </asp:DropDownList>
         <asp:DropDownList runat="server"  ID="ModelsDropDown"  DataTextField ="Name">
            
        </asp:DropDownList>
        <asp:CheckBoxList runat="server" ID="ExtrasCheckBox" AutoPostBack="true" DataTextField ="ExtraName">

        </asp:CheckBoxList>
        <asp:RadioButtonList runat="server" ID="EngineTypes" AutoPostBack="true" DataTextField="Type">

        </asp:RadioButtonList>
        <asp:Button Text="Sumbit" runat="server" OnClick="CollectInfo"  />
    </div>
    </form>
</body>
</html>
