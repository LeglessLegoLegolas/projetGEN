using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class MonService : ServiceBase
    {
        public MonService()
        {
            InitializeComponent();
        }


       private ServiceHost host = null;
        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(WCFServices.MesServices));

            host.Open();

        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
