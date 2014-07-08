using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSOAP
{
    public partial class Authentification : Form
    {
        Plateforme plateforme = new Plateforme();
        public Authentification()
        {

            InitializeComponent();
            
        }

        public void Connexion(string login, string password)
        {
        //    localhost.Stg res = new localhost.Stg("",null,"","","",false);
            localhost.Stg res = new localhost.Stg();
            res._statut_op = false;
            res._operationName = "authentification";
            res._data = new object[] {login,password};
            
            localhost.Stg msg= new localhost.MesServices().m_service(res);
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion(textBox1.Text,textBox2.Text);
        }

        private void TextPassword_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Connexion(textBox1.Text, textBox2.Text);
            }
        }

     

      
    }
}
