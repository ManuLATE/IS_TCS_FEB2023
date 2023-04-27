using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Convertidor
{
    
    [ServiceContract]
    public interface IServicioMoneda
    {

        [OperationContract]
        double convertirPesos(double pesos);
        [OperationContract]
        double convertirDolares(double dolares);
    }    
}
