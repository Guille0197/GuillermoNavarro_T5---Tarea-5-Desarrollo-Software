<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="GuillermoNavarro_T5.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 47px;
            width: 343px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre de usuario:"></asp:Label>
            <asp:TextBox ID="usuario" runat="server" Height="16px" Width="223px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
            <asp:TextBox ID="clave" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Repita la clave:"></asp:Label>
            <asp:TextBox ID="repetir_clave" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Correo electrónico:"></asp:Label>
            <asp:TextBox ID="correo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="apellido" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="País de origen:"></asp:Label>
            <asp:DropDownList ID="paises" runat="server" DataSourceID="SqlDataSource1" DataTextField="pais" DataValueField="pais">
                <asp:ListItem>Panama</asp:ListItem>
                <asp:ListItem>Peru</asp:ListItem>
                <asp:ListItem>España</asp:ListItem>
                <asp:ListItem>Colombia</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Tarea5ConnectionString %>" SelectCommand="SELECT * FROM [pais]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Provincia:"></asp:Label>
            <asp:TextBox ID="provincia" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Código Postal:"></asp:Label>
            <asp:TextBox ID="codigopostal" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Sexo:"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="sexo" SkinID="sexo" Text="Hombre" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sexo" SkinID="sexo" Text="Mujer" />
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Fecha de nacimiento:"></asp:Label>
            <asp:TextBox ID="fecha" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label12" runat="server" Text="(dd/mm/aaaa)"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Comentarios:"></asp:Label>
            <br />
            <asp:TextBox ID="comentarios" runat="server" Height="49px" Rows="3" Width="343px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label14" runat="server" Text="Acepto los términos"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto" />
            <br />
            <asp:Label ID="Label15" runat="server" Text="condiciones"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="43px" Text="Aceptar" Width="246px" />
            <asp:Button ID="consultar" runat="server" Height="43px" Text="Consultar" Width="246px" />
        </div>
    </form>
</body>
</html>
