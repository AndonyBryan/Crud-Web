 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web3.Login" %>

<!DOCTYPE html>

<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Login</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
        }

        form {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            color: #333;
        }

        #txtUsername,
        #txtPassword,
        #btnLogin {
            width: 100%;
            margin-bottom: 15px;
            padding: 10px;
            box-sizing: border-box;
        }

        #btnLogin {
            background-color: #4caf50;
            color: #fff;
            cursor: pointer;
        }

        #btnLogin:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div>
            <h2>Iniciar sesión</h2>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Iniciar sesión" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
