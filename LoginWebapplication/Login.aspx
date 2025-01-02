<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginWebapplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

<style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #6e8efb, #a777e3);
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .login-container {
            background-color: rgba(255, 255, 255, 0.9);
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.2);
            width: 350px;
            text-align: center;
        }
        .title {
            font-size: 24px;
            color: #333;
            margin-bottom: 20px;
        }
        .input-group {
            margin: 10px 0;
        }
        .label {
            display: block;
            margin-bottom: 5px;
            font-size: 16px;
            color: #333;
        }
        .textbox {
            width: 100%;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 5px;
            font-size: 16px;
        }
        #Button3 {
            margin-top: 20px;
        }
        #Button1 {
            width: 100px;
            padding: 12px;
            border: none;
            border-radius: 5px;
            font-size: 16px;
            cursor: pointer;
            margin: 5px;
            background-color: #6e8efb;
            color: #fff;
        }
        #Button1:hover {
            background-color: #5a7de1;
        }
        #Button2 {
            width: 100px;
            padding: 12px;
            border: none;
            border-radius: 5px;
            font-size: 16px;
            cursor: pointer;
            margin: 5px;
            background-color: #ff4d4d;
            color: #fff;
        }
        #Button2:hover {
            background-color: #e60000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Login Form"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button class = "button-group" ID ="Button1" runat="server" Text="Login" BackColor="#66FF99" ForeColor="Red" Height="50px" Width="100px" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" BackColor="Red" Height="50px" Width="100px" />
            <asp:Button class ="button-group" ID="Button3" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
