using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDataContracts;

namespace WCFInterfaces
{
    [ServiceContract(Namespace = "http://localhost:1993/MesServicesWCF"), XmlSerializerFormat]
    public interface IMesServices
    {
        [OperationContract]
        Stg m_service(Stg msg);

        [OperationContract]
        bool authentification(string login, string password);
    }
}
 