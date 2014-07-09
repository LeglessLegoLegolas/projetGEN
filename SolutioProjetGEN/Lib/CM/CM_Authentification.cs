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
        private static List<string> listLogin = Lib.EM_Utilisateur.mLogin();
        private static List<string> listPassword = Lib.EM_Utilisateur.mPassword();

        public static Stg Authentification(Stg msg)
        {
            int i = 0;
            foreach (string s in listLogin)
            {
                if (msg._data[0].ToString() == listLogin[i] && msg._data[1].ToString() == listPassword[i])
                {
                    msg._statut_op = true;
                    break;
                }
                else
                {
                    msg._statut_op = false;
                }
                ++i;
            }
            return msg;
        }
    }