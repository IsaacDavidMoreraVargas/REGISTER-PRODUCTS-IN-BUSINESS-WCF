<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Editar.aspx.cs" Inherits="Editar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <link rel="stylesheet" href="CSS/estilos-registroBus.css"/>
    <title>Sistema registro y visualización productos</title>
    <style type="text/css">
        #form1 {
            height: 773px;
        }
    </style>
</head>
<body style="height: 759px">

     

    <form id="form1" runat="server">

        <asp:Image ID="Image1" runat="server" Height="283px" ImageAlign="Middle" ImageUrl="imagen/sn.png" Width="1063px" />
         
    
        <asp:Label class="label" ID="Label1" runat="server" BorderStyle="None" Height="30px" Text="Descripcion producto" Width="264px" style="margin-top: 22px; top: 331px; left: 13px;" ></asp:Label>
          
        <asp:Label class="label2" ID="TextBox1" runat="server">Precio producto</asp:Label>
          
        <asp:TextBox class="text3" ID="TextDescripcion" value="Menor a 200 caracteres" onclick="" runat="server" TextMode="MultiLine"></asp:TextBox>
          
        <asp:DropDownList CssClass="drop1" ID="DropProvincia" runat="server" OnSelectedIndexChanged="TextRentabilidad_SelectedIndexChanged">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox class="text2" ID="TextPrecio" runat="server"></asp:TextBox>

        
        <asp:ImageButton class="img2" ID="ImageButton1" runat="server" ImageUrl="imagen/home.png" PostBackUrl="index.aspx"/>
    

        <asp:Button CssClass="img5" ID="VerTodos" runat="server" Text="Ver Todos" OnClick="VerTodos_Click" />

        <asp:Button class="img3" ID="Editar2" runat="server" OnClick="Button1_Click" Text="2-Editar" />


        <asp:Label class="label3" ID="TextBox2" runat="server">Rentabilidad producto</asp:Label>
    
        <asp:Panel ID="Panel1" runat="server" style="overflow:auto; position: absolute; top: 353px; left: 292px; height: 320px; width: 500px;">

        <asp:GridView class="text4" ID="TextMostrar" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>

        </asp:Panel>
    


        <asp:TextBox class="text5" ID="TextClave" value="Digite ID producto..." runat="server" onclick="value=''"> </asp:TextBox>
    

        <asp:Button CssClass="img4" ID="Button1" runat="server" Text="1-Buscar producto" OnClick="Button1_Click1" />

    
        <asp:TextBox class="text6" ID="ResultadoOperacion" ReadOnly="true" runat="server" TextMode="MultiLine">Resultado operacion</asp:TextBox>

    
    </form> 
</body>
</html>
