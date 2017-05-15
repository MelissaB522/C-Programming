<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #FF9933; color: #800000; font-size: medium">
<head runat="server">
    <title>Web Controls</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 style="text-align: center">Computer Club Inquiry Form</h1>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 552px; top: 316px; position: absolute" Text="Submit Info" />
        <asp:Button ID="btnShowMembers" runat="server" OnClick="btnShowMembers_Click" style="z-index: 1; left: 510px; top: 378px; position: absolute" Text="See Current Members" CausesValidation="False" />
    
    </div>
        <h3 style="height: 28px; width: 346px;">First Name:<asp:TextBox ID="txtBxFname" runat="server" style="margin-left: 11px" Width="145px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBxFname" EnableClientScript="False" ErrorMessage="Required"></asp:RequiredFieldValidator>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 556px; top: 71px; position: absolute" Text="Classification"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 945px; top: 69px; position: absolute" Text="Special Interests"></asp:Label>
        </h3>
        <h3 style="height: 28px; width: 288px;">Last Name:
            <asp:RadioButton ID="radBtnJrSr" runat="server" AutoPostBack="True" style="z-index: 1; left: 519px; top: 140px; position: absolute; width: 210px;" Text="Junior/Senior" OnCheckedChanged="radButtons_CheckedChanged" />
            <asp:TextBox ID="txtBxLname" runat="server" style="z-index: 1; left: 115px; top: 136px; position: absolute; width: 140px; margin-top: 0px"></asp:TextBox>
            <asp:ListBox ID="lstBxInterests" runat="server" style="z-index: 1; left: 929px; top: 120px; position: absolute">
                <asp:ListItem>Programming Contests</asp:ListItem>
                <asp:ListItem>Tutoring</asp:ListItem>
                <asp:ListItem>Mentoring</asp:ListItem>
                <asp:ListItem>Department Website</asp:ListItem>
                <asp:ListItem>Social Networking</asp:ListItem>
            </asp:ListBox>
        </h3>
        <h3 style="height: 28px; width: 279px;">
            <asp:RadioButton ID="radBtnFresSop" runat="server" AutoPostBack="True" style="z-index: 1; left: 516px; top: 109px; position: absolute; bottom: 526px; width: 223px;" Text="Freshman/Sophomore" OnCheckedChanged="radButtons_CheckedChanged" />
            Phone Number:
            <asp:TextBox ID="txtBxPhone" runat="server" style="z-index: 1; left: 145px; top: 184px; position: absolute; height: 18px"></asp:TextBox>
            <asp:RadioButton ID="RadBtnOther" runat="server" AutoPostBack="True" style="z-index: 1; left: 518px; top: 176px; position: absolute; width: 165px" Text="Other" OnCheckedChanged="radButtons_CheckedChanged" />
        </h3>
        <h3 style="height: 28px; width: 259px;">Student ID:
            <asp:TextBox ID="txtBxID" runat="server" style="z-index: 1; left: 120px; top: 229px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblClassif" runat="server" style="z-index: 1; left: 429px; top: 218px; position: absolute"></asp:Label>
        </h3>
        <p style="height: 214px; width: 353px;">
            <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 10px; top: 277px; position: absolute; height: 203px; width: 290px"></asp:Calendar>
            <asp:Label ID="lblMembers" runat="server" style="z-index: 1; left: 880px; top: 437px; position: absolute" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblSubmit" runat="server"></asp:Label>
        </p>
        <asp:Label ID="lblMeet" runat="server" style="z-index: 1; left: 470px; top: 438px; position: absolute; height: 17px; width: 321px" Text="Click below to see when the club meets next."></asp:Label>
        <asp:Button ID="btnMeeting" runat="server" OnClick="btnMeeting_Click" style="z-index: 1; left: 548px; top: 485px; position: absolute" Text="Next Meeting" CausesValidation="False" />
        <asp:Label ID="lblMSG" runat="server"></asp:Label>
        <asp:GridView ID="grdViewMembers" runat="server" style="z-index: 1; left: 879px; top: 284px; position: absolute; height: 133px; width: 187px" Visible="False">
        </asp:GridView>
    </form>
</body>
</html>
