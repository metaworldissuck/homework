<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web2StringTryIt.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Url Address:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="563px">https://www.public.asu.edu/~ychen10/teaching/honors.html</asp:TextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" 
            Width="86px" />
        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear Result" />
        <br />
        Web Page Download Result:<br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
