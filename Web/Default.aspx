<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Biblioteca.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 327px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="contenedor">
        <div id="cabecera" > 
            <asp:Login ID="LoginUsuario" runat="server" OnAuthenticate="LoginUsuario_Authenticate"></asp:Login>
          

        </div>
        <div id="izquierdo" >
            
        </div>
        <div id="contenido" >

            <asp:TextBox ID="txtBusqueda" runat="server" Width="244px" Height="24px"></asp:TextBox>
            
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="87px" Height="28px" />

            <div>
                <br>
                <table>
                    <tr>
                        <td><asp:GridView ID="gridViewReservas" runat="server" Height="168px" Width="207px">
                </asp:GridView></td>
                        <td class="auto-style1"><asp:Panel ID="PanelControles" runat="server" Height="160px">
                </asp:Panel></td> 

                    </tr>

                </table>
                    
            
                
            

                
                
               
            

        </div>
    

    </div>
    </form>
</body>
</html>
