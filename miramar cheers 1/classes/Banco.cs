using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace miramar_cheers_1
{
    class Banco
    {
        public static MySqlCommand Abrir()
        {
            string strConn = @"server=127.0.0.1;user id=root;database=comandadb";//RegEx
            MySqlConnection cn = new MySqlConnection(strConn);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            return comm;
        }
    }
}
