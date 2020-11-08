using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Agregar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServiceB.IBuscarClient WD = new ServiceB.IBuscarClient();
        DataSet data = WD.GetAll();
        int mayor = TextMostrar.Rows.Count;
        if (mayor >= 0)
        {
            TextMostrar.DataSource = data.Tables[0];
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
        TextDescripcion.Text = "";
        TextPrecio.Text = "";
        TextRentabilidad.Text = "---";
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

        if (TextRentabilidad.Text == "---")
        {
            completado = false;
            negativo += "\n-Rentabilidadvacio";
        }


        try
        {
            rentabilidad = Convert.ToInt32(TextRentabilidad.Text);
        }
        catch (Exception) { completado = false; negativo += "\n-Rentabilidad no es numero"; }

        try
        {
            precio = Convert.ToInt32(TextPrecio.Text);
        }
        catch (Exception) { completado = false; negativo += "\n-Precio no es numero"; }

    }

    protected void ButtonRegistra_Click1(object sender, EventArgs e)
    {
        validar();

        if (completado == true)
        {
            Boolean terminar = true;
            do
            {
                try
                {

                    String LLENAR = "INSERT INTO dbo.product(descripcion,precio, rentabilidad)values('" + descripcion + "'," + precio + "," + rentabilidad + ")";
                    ServiceA.IAgregarClient WD = new ServiceA.IAgregarClient();
                    DataSet data = WD.FillDataProduct(LLENAR);

                    string ESPECIFICO = "select * from dbo.product where descripcion='" + descripcion + "' and precio=" + precio + "and rentabilidad=" + rentabilidad;
                    ServiceB.IBuscarClient WS = new ServiceB.IBuscarClient();
                    DataSet data1 = WS.GetEspecifico(ESPECIFICO);
                    TextMostrar.DataSource = data1.Tables[0];
                    TextMostrar.DataBind();

                    terminar = true;
                }
                catch (Exception h)
                {
                    terminar = false;
                    throw new Exception(h.ToString());
                }

            } while (terminar == false);

            ResultadoOperacion.Text = "Agregado exitosamente";
            vaciarDatos();
        }
        else
        {
            ResultadoOperacion.Text = "Datos erroneos";
            ResultadoOperacion.Text += negativo;
        }
    }
}
