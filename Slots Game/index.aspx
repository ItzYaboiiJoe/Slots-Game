<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Slots_Game.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="180px" Width="200px" />
            <asp:Image ID="Image2" runat="server" Height="180px" Width="200px" />
            <asp:Image ID="Image3" runat="server" Height="180px" Width="200px" />
            <p>
                Your Bet: 
                <asp:TextBox ID="txtBet" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="btnPull" runat="server" Text="Pull The Lever!" OnClick="btnPull_Click" />
            <br />
            <br />
            <asp:Label ID="lblCherryCount" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblMoney" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <p>1 Cherry -  X2 Your Bet</p>
            <p>2 Cherry -  X3 Your Bet</p>
            <p>3 Cherry -  X4 Your Bet</p>
            <p>3 HorseShoes - Jackpot - X100 Your Bet</p>
        </div>
    </form>
</body>
</html>
