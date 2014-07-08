using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WCFDataContracts;

namespace GUI
{
    public partial class Authentification : Form
    {

        private ChannelFactory<WCFInterfaces.IMesServices> channelFactory = null;
        private WCFInterfaces.IMesServices services = null;

        private string login = "jean";
        private string password = "jacques";
        Plateforme plateforme = new Plateforme();

        public Authentification()
        {
            InitializeComponent();

            channelFactory = new ChannelFactory<WCFInterfaces.IMesServices>("maConfiguration");
            services = channelFactory.CreateChannel();
        }

        private void connexion()
        {

            Stg res = new Stg("",null,"authentification","","",false);
          
            services.m_service(res);
            
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
                connexion();
            }
        }
    }
}
