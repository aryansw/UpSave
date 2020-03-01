<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="UpSave.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Slider1" runat="server" AutoPostBack="true"/>
            <asp:TextBox ID="SliderValue" runat="server" AutoPostBack="true"/>
            
            <asp:Label ID="LastUpdate" runat="server" />
            <asp:ScriptManager ID="asm" runat="server" />

        </div>
    </form>
</body>
</html>
