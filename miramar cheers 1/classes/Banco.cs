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

            string strConn = "server=softkleen.com.br;userid=softklee_miramarhealth;password=senac@mirah;database=sofklee_miramarhealth";//RegEx
            MySqlConnection cn = new MySqlConnection(strConn);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            return comm;
        }




        MySqlConnectionStringBuilder b = new MySqlConnectionStringBuilder();
        public Banco()
        { }
        public MySqlCommand Conectar()
        {
            MySqlCommand comm;
            b.Server = "softkleen.com.br";
            b.UserID = "softklee_miramarhealth";
            b.Database = "softklee_miramarhealth";
            b.Port = 3306;
            b.Password = "senac@mirah";
            try
            {
                MySqlConnection cn = new MySqlConnection(b.ToString());
                cn.Open();
                comm = new MySqlCommand
                {
                    Connection = cn
                };
                return comm;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }

        }


    }
}
