using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Editar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServiceB.IBuscarClient WS = new ServiceB.IBuscarClient();
        DataSet data1 = WS.GetAll();
        int mayor = TextMostrar.Rows.Count;

        if (mayor >= 0)
        {
            TextMostrar.DataSource = data1.Tables[0];
            TextMostrar.DataBind();
            ResultadoOperacion.Text = "Mostrando todos \n los productos";

        }
        else
        {
            ResultadoOperacion.Text = "Base de datos \n vacia";
        }

    }

    string descripcion = "";
    int precio = 0;
    int rentabilidad = 0;

    public void vaciarDatos()
    {
        TextClave.Text = "";
        TextDescripcion.Text = "";
        TextPrecio.Text = "";
        DropProvincia.Text = "---";
    }

    bool completado = true;
    string negativo = "";

    public void validar()
    {

        if (TextDescripcion.Text == " ")
        {
            completado = false;
            negativo += "\n-Descripcion vacio";
        }
        else
        {
            descripcion = TextDescripcion.Text;

        }

        if (TextDescripcion.Text.Length <= 0)
        {
            completado = false;
            negativo += "\n-Descripcion vacio";
        }
        else
        {
            descripcion = TextDescripcion.Text;

        }

        if (TextDescripcion.Text.Length > 200)
        {
            completado = false;
            negativo += "\n-Descripcion mayor a 200 caracteres";
        }
        else
        {
            descripcion = TextDescripcion.Text;

        }

        if (TextPrecio.Text == " ")
        {
            completado = false;
            negativo += "\n-Precio vacio";
        }


        if (TextPrecio.Text.Length <= 0)
        {
            completado = false;
            negativo += "\n-Precio vacio";
        }

        if (DropProvincia.Text == "---")
        {
            completado = false;
            negativo += "\n-Rentabilidadvacio";
        }

        try
        {
            rentabilidad = Convert.ToInt32(DropProvincia.Text);
        }
        catch (Exception) { completado = false; negativo += "\n-Rentabilidad no es numero"; }

        try
        {
            precio = Convert.ToInt32(TextPrecio.Text);
        }
        catch (Exception) { completado = false; negativo += "\n-Precio no es numero"; }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        validar();
        TextClave.Text.ToUpper();

        if (completado == true)
        {
            String Editar = "UPDATE dbo.product SET descripcion='" + TextDescripcion.Text + "', precio =" + precio + ", rentabilidad = " + rentabilidad + " where id='" + TextClave.Text + "'";
            ServiceE.IIEditarClient WD = new ServiceE.IIEditarClient();
            DataSet data = WD.EditDataProduct(Editar);

            string ESPECIFICO = "select * from dbo.product where id='" + TextClave.Text + "'";
            ServiceB.IBuscarClient WS = new ServiceB.IBuscarClient();
            DataSet data1 = WS.GetEspecifico(ESPECIFICO);
            TextMostrar.DataSource = data1.Tables[0];
            TextMostrar.DataBind();

            ResultadoOperacion.Text = "Actualizado \n exitosamente";
            vaciarDatos();
        }
        else
        {
            ResultadoOperacion.Text = negativo;

        }

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        VerTodos.Enabled = false;

        try
        {
            string ESPECIFICO = "select * from dbo.product where id='" + TextClave.Text + "'";
            ServiceB.IBuscarClient WS = new ServiceB.IBuscarClient();
            DataSet data1 = WS.GetEspecifico(ESPECIFICO);
            TextMostrar.DataSource = data1.Tables[0];
            TextMostrar.DataBind();
            TextDescripcion.Text = TextMostrar.Rows[0].Cells[1].Text;
            TextPrecio.Text = TextMostrar.Rows[0].Cells[2].Text;
            DropProvincia.Text = TextMostrar.Rows[0].Cells[3].Text;

            ResultadoOperacion.Text += "-Producto encontrado \n -Puede editar datos en espacios luego pinche boton 'EDITAR'";

        }
        catch (Exception r)
        {
            ResultadoOperacion.Text = "No existe ID";
        };
    }

    protected void VerTodos_Click(object sender, EventArgs e)
    {

        ServiceB.IBuscarClient WS = new ServiceB.IBuscarClient();
        DataSet data1 = WS.GetAll();
        TextMostrar.DataSource = data1.Tables[0];
        TextMostrar.DataBind();

        ResultadoOperacion.Text = "Todos los \nproductos mostrados";
    }

    protected void TextRentabilidad_SelectedIndexChanged(object sender, EventArgs e)
    {
        rentabilidad = Convert.ToInt32(DropProvincia.Text);
    }
}
