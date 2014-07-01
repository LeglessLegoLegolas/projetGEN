using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Authentification : Form
    {
        private string login = "jean";
        private string password = "jacques";
        Plateforme plateforme = new Plateforme();

        public Authentification()
        {
            InitializeComponent();
        }

        private void authentification()
        {
            if (txtLogin.Text == login && txtPassword.Text == password)
            {
                Form.ActiveForm.Hide();
                plateforme.ShowDialog();
            }
            else
            {
                labelInformation.Text = "Vous êtes mauvais !";
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == login && txtPassword.Text == password)
            {
                Form.ActiveForm.Hide();
                plateforme.ShowDialog();
            }
            else
            {
                labelInformation.Text = "Vous êtes mauvais !";
            }
        }

        private void txtpassword_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                authentification();
            }
        }
    }
}
