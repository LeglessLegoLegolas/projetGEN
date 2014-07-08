using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using WCFDataContracts;
using WCFInterfaces;

namespace WCFServices
{
    public class MesServices : WCFInterfaces.IMesServices
    {



       public WCFDataContracts.Stg m_service(WCFDataContracts.Stg msg)
       {
           if (msg._operationName == "authentification")
           {
               Stg res = Lib.Auth.Authentification(msg);
               return res;
           }
           else if(msg._operationName == "decrypt1")
           {
               ///apeller WF
               return msg;
           }
           else if (msg._operationName == "decrypt2")
           {
               return msg;
           }
           else if (msg._operationName == "envoi")
           {
               return msg;
           }

           return msg;
       }


     


       
    }
}
