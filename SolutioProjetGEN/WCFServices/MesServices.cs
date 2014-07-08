using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using WCFInterfaces;

namespace WCFServices
{
    public class MesServices : WCFInterfaces.IMesServices
    {



       public WCFDataContracts.Stg m_service(WCFDataContracts.Stg msg)
       {

           msg._data[0] = "jules";
            return msg;
        }


        public bool authentification(string login, string password)
        {
            if (login == "jean" && password == "jacques")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


       
    }
}
