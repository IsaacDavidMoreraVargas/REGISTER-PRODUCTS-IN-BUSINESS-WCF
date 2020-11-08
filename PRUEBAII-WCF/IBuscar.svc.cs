using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PRUEBAII_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service2.svc o Service2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service2 : IIBuscar
    {
        public void DoWork()
        {
        }

        public DataSet GetAll()
        {
            string instruccionLlenar = "select * from dbo.product";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PROGRA-14\\MSSQLSERVER01;Initial Catalog=PRODUCTOS;Integrated Security=True";
            SqlDataAdapter llamadoLenar = new SqlDataAdapter(instruccionLlenar, conn);
            DataSet datasetLLamado = new DataSet();
            llamadoLenar.Fill(datasetLLamado);
            conn.Close();
            return datasetLLamado;
        }

        public DataSet GetEspecifico(string instruccionEspecifico)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PROGRA-14\\MSSQLSERVER01;Initial Catalog=PRODUCTOS;Integrated Security=True";
            SqlDataAdapter llamadoLenar = new SqlDataAdapter(instruccionEspecifico, conn);
            DataSet datasetLLamado = new DataSet();
            llamadoLenar.Fill(datasetLLamado);
            conn.Close();
            return datasetLLamado;
        }

        public DataSet SearchDataProduct(string instruccionBuscar)
        {
            string final = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PROGRA-14\\MSSQLSERVER01;Initial Catalog=PRODUCTOS;Integrated Security=True";
            SqlDataAdapter llamadoLenar = new SqlDataAdapter(instruccionBuscar, conn);
            DataSet datasetLLamado = new DataSet();
            llamadoLenar.Fill(datasetLLamado);
            conn.Close();
            return datasetLLamado;
        }
    }
}
