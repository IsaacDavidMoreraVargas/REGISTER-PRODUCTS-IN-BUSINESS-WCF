using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class listado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string instruccionLlenar = "select * from dbo.product";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PROGRA-14\\MSSQLSERVER01;Initial Catalog=PRODUCTOS;Integrated Security=True";
            SqlDataAdapter llamadoLenar = new SqlDataAdapter(instruccionLlenar, conn);
            DataSet datasetLLamado = new DataSet();
            llamadoLenar.Fill(datasetLLamado);
            TextMostrar.DataSource = datasetLLamado.Tables[0];
            TextMostrar.DataBind();
             mensaje.Text = "Productos encontradas ";

        }
        catch (Exception)
        {
            mensaje.Text = "Existe algun Error";

        }
    }
}