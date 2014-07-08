using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WCFDataContracts
{
    [DataContract]
    public class Stg
    {
        private string info;
        [DataMember]
        public string _info
        {
            get { return info; }
            set { info = value; }
        }

        private object[] data;

        [DataMember]
        public object[] _data
        {
            get { return data; }
            set { data = value; }
        }

        private string operationName;

        [DataMember]
        public string _operationName
        {
            get { return operationName; }
            set { operationName = value; }
        }

        private string tokenApll;

        [DataMember]
        public string _tokenApll
        {
            get { return tokenApll; }
            set { tokenApll = value; }
        }

        private string tokenUser;

        [DataMember]
        public string _tokenUser
        {
            get { return tokenApll; }
            set { tokenApll = value; }
        }

        private bool statut_op;

        [DataMember]
        public bool _statut_op
        {
            get { return statut_op; }
            set { statut_op = value; }
        }

        public Stg()
        {
            
        }

        public Stg(string info, object[] data, string operationName, string tokenApll, string tokenUser, bool statut_op)
        {
            this.info = info;
            this.data = data;
            this.operationName = operationName;
            this.tokenApll = tokenApll;
            this.tokenUser = tokenUser;
            this.statut_op = statut_op;
        }



    }
}
