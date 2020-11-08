using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PRUEBAII_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IIIEditar" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IIIEditar
    {

        [OperationContract, WebGet(UriTemplate = " EditDataProduct")]
        DataSet EditDataProduct(string instruccionEditar);

    }
}
