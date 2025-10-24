<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TpFinalClinica.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>


</head>

    <body class="bg-light">

   
    <div style="text-align: center; margin-top: 30px;">
        <h1 style="color: #0d6efd; font-family: Arial; font-weight: bold;">
            Sistema Clínica Pacheco
        </h1>
    </div>

<body class="bg-light">

    <form id="form1" runat="server" class="vh-100 d-flex justify-content-center align-items-center">
        <div class="card p-4 shadow-lg" style="width: 400px;">
            <h3 class="text-center mb-4">Iniciar sesión</h3>

            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Usuario</label>
                <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="usuario@ejemplo.com">
            </div>

            <div class="mb-3">
                <label for="exampleFormControlTextarea1" class="form-label">Contraseña</label>
                <asp:TextBox ID="TxtPasswords" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Ingresar" CssClass="btn btn-primary w-100" />
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
