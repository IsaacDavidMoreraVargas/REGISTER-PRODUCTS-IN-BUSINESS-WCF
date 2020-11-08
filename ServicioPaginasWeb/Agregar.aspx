<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Agregar.aspx.cs" Inherits="Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link rel="stylesheet" href="CSS/estilos-registroRuta.css"/>
    <title>Sistema registro y visualización autobuses</title>
    <style type="text/css">
        #form1 {
            height: 773px;
        }
    </style>
</head>
<body style="height: 759px">

    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="283px" ImageAlign="Middle" ImageUrl="imagen/sn.png" Width="1063px" />
    
         
        <asp:Label class="label" ID="Label1" runat="server" BorderStyle="None" Height="30px" Text="Descripcion producto" Width="264px" style="margin-top: 22px; top: 325px; left: 15px;" ></asp:Label>
          
        <asp:Label class="label2" ID="TextBox1" runat="server">Precio producto</asp:Label>
        <asp:Label class="label3" ID="TextBox2" runat="server">Rentabilidad producto</asp:Label>
          
        <asp:DropDownList CssClass="drop1" ID="TextRentabilidad" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>

       

        <asp:Button class="img1" ID="ButtonRegistra" runat="server" Text="Registrar" OnClick="ButtonRegistra_Click1"  />


        <asp:Panel ID="Panel1" CssClass="paneles" runat="server">
            <asp:GridView ID="TextMostrar" style="position:absolute; top: 6px; left: 26px;" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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


        <asp:ImageButton class="img2" ID="ImageButton1" runat="server" ImageUrl="~/imagen/home.png" PostBackUrl="index.aspx"/>


        <asp:TextBox class="text3" ID="TextDescripcion" onclick="" runat="server" TextMode="MultiLine"></asp:TextBox>
          

        <asp:TextBox class="text1" ID="TextPrecio" runat="server"></asp:TextBox>


        <asp:TextBox ID="ResultadoOperacion" CssClass="paneles1" ReadOnly="true" runat="server" TextMode="MultiLine">Aqui aparecera el resultado de las operaiones</asp:TextBox>


    </form>
</body>
</html>
