using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PRUEBAII_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IIAgregar
    {
        public DataSet FillDataProduct(string instruccionLlenar)
        {
            string final = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PROGRA-14\\MSSQLSERVER01;Initial Catalog=PRODUCTOS;Integrated Security=True";
            SqlDataAdapter llamadoLenar = new SqlDataAdapter(instruccionLlenar, conn);
            DataSet datasetLLamado = new DataSet();
            llamadoLenar.Fill(datasetLLamado);
            conn.Close();
            return datasetLLamado;
        }

    

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

   
    }
}
