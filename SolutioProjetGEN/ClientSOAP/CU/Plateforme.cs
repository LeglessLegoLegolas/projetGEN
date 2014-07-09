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
    public partial class Plateforme : Form
    {
        public Plateforme()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var monserv = new GenService.GenService();
            monserv.SendDocumentOperation("test", "aimer vierge verge vergeture jules.mondot@gmail.com pute", "958638");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());

                var chaine = sr.ReadToEnd().ToString();


                localhost.Stg res = new localhost.Stg();
                res._statut_op = false;
                res._operationName = "decrypt";
                res._data = new object[] { chaine };

               new localhost.MesServices().m_service(res);

               label2.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

    }
}
