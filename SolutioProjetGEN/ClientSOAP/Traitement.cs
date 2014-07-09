using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSOAP
{
    class Traitement
    {

        public void Connexion(string login, string password)
        {
            //    localhost.Stg res = new localhost.Stg("",null,"","","",false);
            localhost.Stg res = new localhost.Stg();
            res._statut_op = false;
            res._operationName = "authentification";
            res._data = new object[] { login, password };

            localhost.Stg msg = new localhost.MesServices().m_service(res);

            if (msg._statut_op == true)
            {
                Form.ActiveForm.Hide();
                plateforme.ShowDialog();
            }
            else
            {
                label3.Text = "Vous êtes mauvais !";
            }
        }
    }
}
