using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDataContracts;

namespace Lib
{
    public class Auth

    {

        public static Stg Authentification(Stg msg)
        {
            if (msg._data[0].ToString() == "jean" && msg._data[1].ToString() == "jacques")
            {
                msg._statut_op = true;
                return msg;
            }
            else
            {
                msg._statut_op = false;
                return msg;
            }
        }
    }
}
