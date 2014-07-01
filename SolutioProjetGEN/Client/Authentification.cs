using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Authentification : Form
    {
        private string login = "jean";
        private string password = "jacques";

        public Authentification()
        {
            InitializeComponent();
        }

        private void authentification()
        {
            if (txtLogin.Text == login && txtPassword.Text == password)
            {
                labelInformation.Text = "Vous êtes authentifiés, c'est cool !";
            }
            else
            {
                labelInformation.Text = "Vous êtes mauvais !";
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            authentification();
        }

        private void txtpassword_keydown(object sender, KeyEventArgs e)
        {
            authentification();
        }
    }
}
