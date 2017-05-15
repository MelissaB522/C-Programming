<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        #form1 {
            width: 996px;
        }
    </style>
</head>
<body style="background-color: #6666FF">
    <form id="form1" runat="server">
    <div style="text-align: center">    
        <span class="auto-style2"><strong>REGEX Validation</strong></span><strong><br class="auto-style1" />
        </strong>
        <asp:Label ID="lblMessage" runat="server" CssClass="auto-style1"></asp:Label>
        </div>   
    <p style="width: 598px">
        <strong>First Name: </strong>
    <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
        <asp:Label ID="lblFirst" runat="server"></asp:Label>
        <asp:TextBox ID="txtResults" runat="server" Height="165px" Rows="5" style="z-index: 1; left: 631px; top: 107px; position: absolute; font-size: large; width: 333px;" TextMode="MultiLine" Visible="False"></asp:TextBox>
    </p>
        <p style="width: 598px">
            <strong>Last Name: </strong>
            <asp:TextBox ID="txtLast" runat="server"></asp:TextBox>
            <asp:Label ID="lblLast" runat="server"></asp:Label>
    </p>
        <p style="width: 599px">
            <strong>Age: </strong>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:Label ID="lblAge" runat="server"></asp:Label>
    </p>
        <p style="width: 599px">
            <strong>Birth Date: </strong>
            <asp:TextBox ID="txtBDay" runat="server"></asp:TextBox>
            <asp:Label ID="lblBDay" runat="server"></asp:Label>
    </p>
        <p style="width: 600px">
            <strong>Phone Number: </strong>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <asp:Label ID="lblPhone" runat="server"></asp:Label>
    </p>
        <p style="text-align: left; width: 135px">
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
    </p>
        <p style="text-align: left">
            &nbsp;</p>
    </form>
</body>
</html>
