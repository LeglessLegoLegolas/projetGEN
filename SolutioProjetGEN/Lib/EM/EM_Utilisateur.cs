using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    class EM_Utilisateur
    {
        public static List<string> mLogin()
        {
            List<string> myList = new List<string>();

            var data = new generatorDatabaseDataSetTableAdapters.UserTableAdapter();
            foreach (var dr in data.GetData())
            {
                myList.Add(dr["Login"].ToString());
            }
            return myList;
        }

        public static List<string> mPassword()
        {
            List<string> myList2 = new List<string>();

            var data = new generatorDatabaseDataSetTableAdapters.UserTableAdapter();
            foreach (var dr in data.GetData())
            {
                myList2.Add(dr["Password"].ToString());
            }
            return myList2;
        }
    }
}
